namespace BackendRandomizer.Models
{
    public class RollHistory
    {
        public int Id { get; set; }
        public int WeaponId { get; set; }
        public DateTime Timestamp { get; set; }
        public bool? Won { get; set; }

    }
}
