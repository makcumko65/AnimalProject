using Domain.Common;
using Domain.Enums;
using System;   
using System.Collections.Generic;

namespace Domain.Models
{
    public class Animal : AnimalBase
    {
        public Animal()
        {
            AnimalVaccinations = new List<AnimalVaccination>();
            AnimalAttitudes = new List<AnimalAttitudeTo>();
            AnimalNeeds = new List<AnimalNeeds>();
            AnimalKeepings = new List<AnimalKeeping>();
            AnimalProcessings = new List<AnimalProcessing>();
            AnimalDefects = new List<AnimalDefects>();
            Images = new List<Image>();
        }
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
        public Address Address { get; set; }
        public long CategotyId { get; set; }
        public Category Category { get; set; }
        public long FoodId { get; set; }
        public Food Food { get; set; }
        public IList<AnimalVaccination> AnimalVaccinations { get; set; }
        public IList<AnimalAttitudeTo> AnimalAttitudes { get; set; }
        public IList<AnimalDefects> AnimalDefects { get; set; }
        public IList<AnimalKeeping> AnimalKeepings { get; set; }
        public IList<AnimalProcessing> AnimalProcessings { get; set; }
        public IList<AnimalNeeds> AnimalNeeds { get; set; }
        public IList<Image> Images { get; set; }

    }
}
