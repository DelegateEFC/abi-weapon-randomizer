using BackendRandomizer.Models;
namespace BackendRandomizer.DTO
{
    public class AttachmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Attachment.Socket Slot { get; set; }
    }
}
