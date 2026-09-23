using Microsoft.EntityFrameworkCore;

namespace BackendRandomizer.Models
{
    public class WeaponAttachment
    {
        public int WeaponId { get; set; }
        public int AttachmentId { get; set; }

        public Weapon Weapon { get; set; } = null!;
        public Attachment Attachment { get; set; } = null!;
    }
}
