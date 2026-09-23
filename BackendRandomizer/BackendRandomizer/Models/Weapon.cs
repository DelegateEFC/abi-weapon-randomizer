namespace BackendRandomizer.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public enum Category
        {
            AssaultRifle,
            SubmachineGun,
            Carabine,
            MarksmanRifle,
            BoltActionRifle,
            Shotgun,
            LightMachineGun,
            Pistol
        }
        public Category WeaponCategory { get; set; }
        public List<WeaponAttachment> WeaponAttachments { get; set; } = new List<WeaponAttachment>();
    }
}
