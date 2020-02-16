using Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class AnimalAttitudeTo : AnimalBase
    {
        public long AnimalId { get; set; }
        public Animal Animal { get; set; }

        public long AttitudeId { get; set; }
        public AttitudeTo AttitudeTo { get; set; }

        //req
        //range 1-5
        public int Mark { get; set; }
    }
}
