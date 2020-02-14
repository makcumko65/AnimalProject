namespace Domain.Models
{
    public class AnimalKeeping
    {
        public long AnimalId { get; set; }
        public Animal Animal { get; set; }
        public long KeepingId { get; set; }
        public Keeping Keeping { get; set; }
    }
}
