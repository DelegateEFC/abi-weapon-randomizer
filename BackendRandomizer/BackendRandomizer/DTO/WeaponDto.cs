using BackendRandomizer.Models;
namespace BackendRandomizer.DTO
{
    public class WeaponDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public Weapon.Category Category { get; set; }

        public List<AttachmentDto> Attachments { get; set; }
    }
}
