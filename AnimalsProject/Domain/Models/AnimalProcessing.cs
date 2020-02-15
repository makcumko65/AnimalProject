using Domain.Common;
using System;

namespace Domain.Models
{
    public class AnimalProcessing : AnimalBase
    {
        public long AnimalId { get; set; }
        public Animal Animal { get; set; }
        public long ProcessingId { get; set; }
        public Processing Processing { get; set; }
        public DateTime ProcessingDate { get; set; }
        public DateTime NextProcessingDate { get; set; }
    }
}
