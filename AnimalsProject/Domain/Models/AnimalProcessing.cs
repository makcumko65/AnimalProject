using Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class AnimalProcessing : AnimalBase
    {
        public long AnimalId { get; set; }
        public Animal Animal { get; set; }
        public long ProcessingId { get; set; }
        public Processing Processing { get; set; }

        [DataType(DataType.Date)]
        public DateTime ProcessingDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime NextProcessingDate { get; set; }
    }
}
