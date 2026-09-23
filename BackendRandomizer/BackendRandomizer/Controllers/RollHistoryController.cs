using BackendRandomizer.Data;
using BackendRandomizer.Models;
using BackendRandomizer.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendRandomizer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RollHistoryController : ControllerBase
    {
        private readonly AppDbContext context;

        public RollHistoryController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: api/<RollHistoryController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RollHistory>>> Get()
        {
            // OrderByDescending sortuje od najnowszego
            var history = await context.RollHistory
                .OrderByDescending(h => h.Timestamp)
                .ToListAsync();

            return Ok(history);
        }

        // POST api/<RollHistoryController>
        [HttpPost]
        public async Task<ActionResult<RollHistory>> Post([FromBody] RollHistoryCreateDto dto)
        {
            var entry = new RollHistory
            {
                WeaponId = dto.WeaponId,
                Won = dto.Won,
                Timestamp = DateTime.UtcNow
            };

            context.RollHistory.Add(entry);
            await context.SaveChangesAsync();

            return Ok(entry);
        }
    }
}
