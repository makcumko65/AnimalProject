using Domain.Common;
using Domain.Enums;
using System;

namespace Application.DTO
{
    public class AnimalDTO : AnimalBase
    {
        public long Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Weight { get; set; }
        public double WithersHeight { get; set; }
        public double NeckCircumference { get; set; }
        public bool IsAdopted { get; set; }
        public bool ContinuatitonOfTreatment { get; set; }
        public long ChipNumber { get; set; }
        public Gender Gender { get; set; }
        public Sterialization Sterialization { get; set; }
        public long AddressId { get; set; }
        public long CategoryId { get; set; }
        public long FoodId { get; set; }
    }
}
