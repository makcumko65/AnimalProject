using Domain.Common;
using System;

namespace Domain.Models
{
    public class AnimalVaccination : AnimalBase
    {
        public long AnimalId { get; set; }
        public Animal Animal { get; set; }
        public long VaccinationId { get; set; }
        public Vaccination Vaccination { get; set; }
        public DateTime VaccinationDate { get; set; }
        public DateTime NextVaccinationDate { get; set; }

    }
}
