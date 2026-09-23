using BackendRandomizer.Data;
using BackendRandomizer.DTO;
using BackendRandomizer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendRandomizer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponsController : ControllerBase
    {
        private readonly AppDbContext context;

        public WeaponsController(AppDbContext context)
        {
            this.context = context;
        } 

        // GET: api/<WeaponsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WeaponDto>>> Get()
        {
            var weapons = await context.Weapons
                .Include(weapons => weapons.WeaponAttachments)
                .ThenInclude(weapons => weapons.Attachment)
                .ToListAsync();

            var weaponDtos = weapons.Select(w => new WeaponDto
            {
                Id = w.Id,
                Name = w.Name,
                Category = w.WeaponCategory,
                Attachments = w.WeaponAttachments.Select(wa => new AttachmentDto
                {
                    Id = wa.AttachmentId,
                    Name = wa.Attachment.Name,
                    Slot = wa.Attachment.Slot
                }).ToList()
            });

            return Ok(weaponDtos);
        }

        private async Task<Dictionary<int, double>> CalculateWeights(List<Weapon> weapons)
        {
            var history = await context.RollHistory
               .OrderByDescending(h => h.Timestamp)
               .ToListAsync();

            var weights = new Dictionary<int, double>();

            foreach (var weapon in weapons)
            {
                var weaponHistory = history.Where(h => h.WeaponId == weapon.Id).ToList();

                if (!weaponHistory.Any())
                {
                    weights[weapon.Id] = 1.0;
                    continue;
                }

                var lastEntry = weaponHistory.First();
                int rollAgo = history.IndexOf(lastEntry) + 1;

                double baseWeight;
                double growthRate;

                if (lastEntry.Won == true)
                {
                    baseWeight = 0.10;
                    growthRate = 0.10;
                }
                else if (lastEntry.Won == false)
                {
                    baseWeight = 0.30;
                    growthRate = 0.25;
                }
                else
                {
                    baseWeight = 0.60;
                    growthRate = 0.15;
                }

                double weight = baseWeight + (rollAgo * growthRate);
                weights[weapon.Id] = Math.Min(weight, 1.0);
            }
            return weights;
        }

        // GET: api/<WeaponsController>
        [HttpGet("random")]
        public async Task<ActionResult<WeaponDto>> GetRandom()
        {
            var weapons = await context.Weapons
                .Include(weapons => weapons.WeaponAttachments)
                .ThenInclude(weapons => weapons.Attachment)
                .ToListAsync();

            if (!weapons.Any())
            {
                return NotFound("No weapons available.");
            }

            var weights = await CalculateWeights(weapons);

            double totalWeight = weights.Values.Sum();
            double roll = Random.Shared.NextDouble() * totalWeight;

            double cumulative = 0;
            Weapon selectedWeapon = weapons[0];

            foreach (var weapon in weapons)
            {
                cumulative += weights[weapon.Id];
                if(roll <= cumulative)
                {
                    selectedWeapon = weapon;
                    break;
                }
            }

            
            var grouped = selectedWeapon.WeaponAttachments.GroupBy(wa => wa.Attachment.Slot);
            List<AttachmentDto> randomAttachment = new List<AttachmentDto>();

            foreach(var group in grouped)
            {
                var groupList = group.ToList();
                int randomIndex = Random.Shared.Next(groupList.Count);

                var chosen = groupList[randomIndex];

                var attachmentDto = new AttachmentDto
                {
                    Id = chosen.AttachmentId,
                    Name = chosen.Attachment.Name,
                    Slot = chosen.Attachment.Slot
                };
                randomAttachment.Add(attachmentDto);
            }

            var weaponDto = new WeaponDto
            {
                Id = selectedWeapon.Id,
                Name = selectedWeapon.Name,
                Category = selectedWeapon.WeaponCategory,
                Weight = weights[selectedWeapon.Id],
                Attachments = randomAttachment
            };

            return Ok(weaponDto);
        }

        [HttpGet("weights")]
        public async Task<ActionResult<Dictionary<int, double>>> GetWeights()
        {
            var weapons = await context.Weapons.ToListAsync();
            var weights = await CalculateWeights(weapons);
            return Ok(weights);
        }
    }
}