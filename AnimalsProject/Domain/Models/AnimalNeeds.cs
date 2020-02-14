namespace Domain.Models
{
    public class AnimalNeeds
    {
        public long AnimalId { get; set; }
        public Animal Animal { get; set; }
        public long NeedsId { get; set; }
        public Needs Needs { get; set; }
    }
}
