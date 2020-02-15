using Domain.Common;

namespace Domain.Models
{
    public class AnimalAttitudeTo : AnimalBase
    {
        public long AnimalId { get; set; }
        public Animal Animal { get; set; }
        public long AttitudeId { get; set; }
        public AttitudeTo AttitudeTo { get; set; }
        public int Mark { get; set; }
    }
}
