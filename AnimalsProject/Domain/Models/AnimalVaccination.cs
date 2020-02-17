using Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class AnimalVaccination : AnimalBase
    {
        public long AnimalId { get; set; }
        public Animal Animal { get; set; }
        public long VaccinationId { get; set; }
        public Vaccination Vaccination { get; set; }

        [DataType(DataType.Date)]
        public DateTime VaccinationDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime NextVaccinationDate { get; set; }

    }
}
