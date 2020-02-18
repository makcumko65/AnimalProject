using Domain.Common;
using Domain.Models;
using System;
using System.Collections.Generic;

namespace Application.DTO
{
    public class AnimalDto : AnimalBase
    {
        public AnimalDto()
        {
            Vaccinations = new List<VaccinationDto>();
            Attitudes = new List<AttitudeToDto>();
            Needs = new List<NeedsDto>();
            Keepings = new List<KeepingDto>();
            Processings = new List<ProcessingDto>();
            Defects = new List<DefectDto>();
        }
        public long Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Weight { get; set; }
        public double WithersHeight { get; set; }
        public double NeckCircumference { get; set; }
        public bool IsAdopted { get; set; }
        public bool ContinuatitonOfTreatment { get; set; }
        public long ChipNumber { get; set; }
        public int Gender { get; set; }
        public int Sterialization { get; set; }
        public long AddressId { get; set; }
        public Address Address { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public long FoodId { get; set; }
        public Food Food { get; set; }
        public IList<VaccinationDto> Vaccinations { get; set; }
        public IList<AttitudeToDto> Attitudes { get; set; }
        public IList<DefectDto> Defects { get; set; }
        public IList<KeepingDto> Keepings { get; set; }
        public IList<ProcessingDto> Processings { get; set; }
        public IList<NeedsDto> Needs { get; set; }
    }
}
