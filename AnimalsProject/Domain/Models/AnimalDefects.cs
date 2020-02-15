using Domain.Common;

namespace Domain.Models
{
    public class AnimalDefects : AnimalBase
    {
        public long AnimalId { get; set; }
        public Animal Animal { get; set; }
        public long DefectsId { get; set; }
        public Defect Defect { get; set; }
    }
}
