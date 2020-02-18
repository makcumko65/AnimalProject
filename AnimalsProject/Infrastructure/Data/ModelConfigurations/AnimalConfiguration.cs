using System;
using Domain.Models;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.ModelConfigurations
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.Property(animl => animl.Id).ValueGeneratedOnAdd();
            builder.Property(animl => animl.IsAdopted).IsRequired();
            builder.Property(animl => animl.ContinuatitonOfTreatment).IsRequired();
            builder.Property(animl => animl.IsAdopted).IsRequired();
            builder.Property(animl => animl.Gender).IsRequired();   
            builder.Property(animl => animl.CategoryId).IsRequired();
            builder.Property(animl => animl.AddressId).IsRequired();
            builder.Property(animl => animl.Name).IsRequired().HasMaxLength(200);
            builder.Property(animl => animl.DateOfBirth).IsRequired();
            builder.Property(animl => animl.Weight).IsRequired();
            builder.Property(animl => animl.WithersHeight).IsRequired();

            DataSeedConfigure(builder);
        }

        private void DataSeedConfigure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasData(
                    new Animal
                    {
                        Id = 2,
                        Name = "Lola",
                        CategoryId = 2,
                        AddressId = 2,
                        FoodId = 2,
                        ChipNumber = 13345678,
                        ContinuatitonOfTreatment = false,
                        Weight = 25.5,
                        WithersHeight = 45,
                        DateOfBirth = DateTime.Parse("18/08/2017"),
                        Gender = Gender.Female,
                        Sterialization = Sterialization.NotForHealthReasons,
                        NeckCircumference = 9.2,
                        IsAdopted = true,
                    },
                    new Animal
                    {
                        Id = 3,
                        Name = "Josh",
                        CategoryId = 1,
                        AddressId = 1,
                        FoodId = 1,
                        ChipNumber = 12245678,
                        ContinuatitonOfTreatment = true,
                        Weight = 15.5,
                        WithersHeight = 15,
                        DateOfBirth = DateTime.Parse("07/10/2018"),
                        Gender = Gender.Male,
                        Sterialization = Sterialization.Yes,
                        NeckCircumference = 10.2,
                        IsAdopted = false,
                    },
                    new Animal
                    {
                        Id = 4,
                        Name = "Jimbo",
                        CategoryId = 3,
                        AddressId = 4,
                        FoodId = 3,
                        ChipNumber = 12445678,
                        ContinuatitonOfTreatment = false,
                        Weight = 5.5,
                        WithersHeight = 5,
                        DateOfBirth = DateTime.Parse("08/08/2014"),
                        Gender = Gender.Male,
                        Sterialization = Sterialization.NotByAge,
                        NeckCircumference = 10.2,
                        IsAdopted = false,
                    },
                    new Animal
                    {
                        Id = 5,
                        Name = "Arnold",
                        CategoryId = 1,
                        AddressId = 1,
                        FoodId = 1,
                        ChipNumber = 12355678,
                        ContinuatitonOfTreatment = false,
                        Weight = 2.5,
                        WithersHeight = 15,
                        DateOfBirth = DateTime.Parse("08/01/2018"),
                        Gender = Gender.Female,
                        Sterialization = Sterialization.Yes,
                        NeckCircumference = 10.2,
                        IsAdopted = false,
                    },
                    new Animal
                    {
                        Id = 6,
                        Name = "Sonia",
                        CategoryId = 2,
                        AddressId = 6,
                        FoodId = 2,
                        ChipNumber = 12346678,
                        ContinuatitonOfTreatment = true,
                        Weight = 25.5,
                        WithersHeight = 45,
                        DateOfBirth = DateTime.Parse("02/12/2019"),
                        Gender = Gender.Male,
                        Sterialization = Sterialization.Yes,
                        NeckCircumference = 1.2,
                        IsAdopted = false,
                    },
                    new Animal
                    {
                        Id = 7,
                        Name = "Havoc",
                        CategoryId = 1,
                        AddressId = 6,
                        FoodId = 1,
                        ChipNumber = 12345778,
                        ContinuatitonOfTreatment = true,
                        Weight = 25.5,
                        WithersHeight = 45,
                        DateOfBirth = DateTime.Parse("08/11/2018"),
                        Gender = Gender.Male,
                        Sterialization = Sterialization.NotForHealthReasons,
                        NeckCircumference = 10.2,
                        IsAdopted = false,
                    },
                    new Animal
                    {
                        Id = 8,
                        Name = "Khora",
                        CategoryId = 1,
                        AddressId = 2,
                        FoodId = 1,
                        ChipNumber = 12345688,
                        ContinuatitonOfTreatment = true,
                        Weight = 2.5,
                        WithersHeight = 15,
                        DateOfBirth = DateTime.Parse("08/10/2018"),
                        Gender = Gender.Male,
                        Sterialization = Sterialization.Yes,
                        NeckCircumference = 10.2,
                        IsAdopted = false,
                    },
                    new Animal
                    {
                        Id = 9,
                        Name = "Alpaca",
                        CategoryId = 2,
                        AddressId = 2,
                        FoodId = 1,
                        ChipNumber = 12345681,
                        ContinuatitonOfTreatment = false,
                        Weight = 12.5,
                        WithersHeight = 5,
                        DateOfBirth = DateTime.Parse("03/10/2018"),
                        Gender = Gender.Female,
                        Sterialization = Sterialization.NotByAge,
                        NeckCircumference = 1.2,
                        IsAdopted = false,
                    },
                    new Animal
                    {
                        Id = 10,
                        Name = "Bee",
                        CategoryId = 1,
                        AddressId = 5,
                        FoodId = 3,
                        ChipNumber = 33345688,
                        ContinuatitonOfTreatment = true,
                        Weight = 2.5,
                        WithersHeight = 15,
                        DateOfBirth = DateTime.Parse("03/10/2018"),
                        Gender = Gender.Male,
                        Sterialization = Sterialization.Yes,
                        NeckCircumference = 10.2,
                        IsAdopted = false,
                    },
                    new Animal
                    {
                        Id = 11,
                        Name = "Puma",
                        CategoryId = 3,
                        AddressId = 4,
                        FoodId = 2,
                        ChipNumber = 11145688,
                        ContinuatitonOfTreatment = true,
                        Weight = 21.5,
                        WithersHeight = 5,
                        DateOfBirth = DateTime.Parse("08/07/2016"),
                        Gender = Gender.Female,
                        Sterialization = Sterialization.Yes,
                        NeckCircumference = 10.2,
                        IsAdopted = false,
                    },
                    new Animal
                    {
                        Id = 12,
                        Name = "Aladin",
                        CategoryId = 1,
                        AddressId = 1,
                        FoodId = 1,
                        ChipNumber = 444445688,
                        ContinuatitonOfTreatment = false,
                        Weight = 222.5,
                        WithersHeight = 15,
                        DateOfBirth = DateTime.Parse("08/10/2018"),
                        Gender = Gender.Male,
                        Sterialization = Sterialization.Yes,
                        NeckCircumference = 10.2,
                        IsAdopted = false,
                    },
                    new Animal
                    { 
                        Id = 13,
                        Name = "Aladin",
                        CategoryId = 1,
                        AddressId = 2,
                        FoodId = 1,
                        ChipNumber = 12342138,
                        ContinuatitonOfTreatment = true,
                        Weight = 2.5,
                        WithersHeight = 15,
                        DateOfBirth = DateTime.Parse("02/07/2018"),
                        Gender = Gender.Male,
                        Sterialization = Sterialization.Yes,
                        NeckCircumference = 10.2,
                        IsAdopted = false,
                    },
                    new Animal
                    {
                        Id = 14,
                        Name = "Neo",
                        CategoryId = 1,
                        AddressId = 2,
                        FoodId = 1,
                        ChipNumber = 32132688,
                        ContinuatitonOfTreatment = true,
                        Weight = 42.5,
                        WithersHeight = 125,
                        DateOfBirth = DateTime.Parse("08/10/2018"),
                        Gender = Gender.Male,
                        Sterialization = Sterialization.Yes,
                        NeckCircumference = 10.2,
                        IsAdopted = false,
                    },
                    new Animal
                    {
                        Id = 15,
                        Name = "Theo",
                        CategoryId = 2,
                        AddressId = 4,
                        FoodId = 3,
                        ChipNumber = 88885688,
                        ContinuatitonOfTreatment = false,
                        Weight = 2.5,
                        WithersHeight = 15,
                        DateOfBirth = DateTime.Parse("08/02/2012"),
                        Gender = Gender.Female,
                        Sterialization = Sterialization.Yes,
                        NeckCircumference = 0.2,
                        IsAdopted = true,
                    },
                    new Animal
                    {
                        Id = 16,
                        Name = "Baron",
                        CategoryId = 2,
                        AddressId = 3,
                        FoodId = 2,
                        ChipNumber = 12345611,
                        ContinuatitonOfTreatment = true,
                        Weight = 2.5,
                        WithersHeight = 15,
                        DateOfBirth = DateTime.Parse("04/10/2014"),
                        Gender = Gender.Male,
                        Sterialization = Sterialization.Yes,
                        NeckCircumference = 10.2,
                        IsAdopted = true,
                    }
            ); 
        }
    }
}
