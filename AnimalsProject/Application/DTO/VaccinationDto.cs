using Domain.Common;
using Domain.Models;
using System;

namespace Application.DTO
{
    public class VaccinationDto : AnimalBase
    {
        public VaccinationDto(Vaccination vac, DateTime vaccinationDate, DateTime nextVaccinationDate)
        {
            Id = vac.Id;
            Name = vac.Name;
            Type = vac.Type;
            VaccinationDate = vaccinationDate;
            NextVaccinationDate = nextVaccinationDate;
        }
        public VaccinationDto(){}
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime VaccinationDate { get; set; }
        public DateTime NextVaccinationDate { get; set; }
    }
}
