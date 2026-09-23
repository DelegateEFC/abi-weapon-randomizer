namespace BackendRandomizer.Models
{
    public class Attachment
    {
        public enum Socket
        {
            Scope,
            Stock,
            Muzzle,
            FrontGrip,
            BackGrip
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Socket Slot { get; set; }
        
        public List<WeaponAttachment> WeaponAttachments { get; set; } = new List<WeaponAttachment>();
    }
}
