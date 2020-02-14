namespace Domain.Models
{
    public class AnimalDefects
    {
        public long AnimalId { get; set; }
        public Animal Animal { get; set; }
        public long DefectsId { get; set; }
        public Defect Defect { get; set; }
    }
}
