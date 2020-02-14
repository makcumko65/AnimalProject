namespace Domain.Models
{
    public class AnimalProcessing
    {
        public long AnimalId { get; set; }
        public Animal Animal { get; set; }
        public long ProcessingId { get; set; }
        public Processing Processing { get; set; }
    }
}
