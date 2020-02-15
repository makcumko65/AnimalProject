using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Data
{
    public class AnimalContext : DbContext
    {
        public AnimalContext(DbContextOptions options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<AttitudeTo> AttitudeTo { get; set; }
        public DbSet<Defect> Defects { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Keeping> Keepings { get; set; }
        public DbSet<Needs> Needs { get; set; }
        public DbSet<Processing> Processings { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=(localdb)\\MSSQLLocalDB; Database=AnimalDb; Integrated Security=True;";

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AnimalAttitudeTo>()
                .HasKey(at => new { at.AnimalId, at.AttitudeId });
            modelBuilder.Entity<AnimalAttitudeTo>()
                .HasOne(a => a.Animal)
                .WithMany(at => at.AnimalAttitudes)
                .HasForeignKey(a => a.AnimalId);
            modelBuilder.Entity<AnimalAttitudeTo>()
                .HasOne(at => at.AttitudeTo)
                .WithMany(a => a.AnimalAttitudes)
                .HasForeignKey(at => at.AttitudeId);

            modelBuilder.Entity<AnimalDefects>()
                .HasKey(at => new { at.AnimalId, at.DefectsId });

            modelBuilder.Entity<AnimalDefects>()
                .HasOne(a => a.Animal)
                .WithMany(at => at.AnimalDefects)
                .HasForeignKey(a => a.AnimalId);

            modelBuilder.Entity<AnimalDefects>()
                .HasOne(at => at.Defect)
                .WithMany(a => a.AnimalDefects)
                .HasForeignKey(at => at.DefectsId);

            modelBuilder.Entity<AnimalKeeping>()
                .HasKey(at => new { at.AnimalId, at.KeepingId });
            modelBuilder.Entity<AnimalKeeping>()
                .HasOne(a => a.Animal)
                .WithMany(at => at.AnimalKeepings)
                .HasForeignKey(a => a.AnimalId);
            modelBuilder.Entity<AnimalKeeping>()
                .HasOne(at => at.Keeping)
                .WithMany(a => a.AnimalKeepings)
                .HasForeignKey(at => at.KeepingId);

            modelBuilder.Entity<AnimalNeeds>()
                .HasKey(at => new { at.AnimalId, at.NeedsId });
            modelBuilder.Entity<AnimalNeeds>()
                .HasOne(a => a.Animal)
                .WithMany(at => at.AnimalNeeds)
                .HasForeignKey(a => a.AnimalId);
            modelBuilder.Entity<AnimalNeeds>()
                .HasOne(at => at.Needs)
                .WithMany(a => a.AnimalNeeds)
                .HasForeignKey(at => at.NeedsId);

            modelBuilder.Entity<AnimalProcessing>()
                .HasKey(at => new { at.AnimalId, at.ProcessingId });
            modelBuilder.Entity<AnimalProcessing>()
                .HasOne(a => a.Animal)
                .WithMany(at => at.AnimalProcessings)
                .HasForeignKey(a => a.AnimalId);
            modelBuilder.Entity<AnimalProcessing>()
                .HasOne(at => at.Processing)
                .WithMany(a => a.AnimalProcessings)
                .HasForeignKey(at => at.ProcessingId);

            modelBuilder.Entity<AnimalVaccination>()
                .HasKey(at => new { at.AnimalId, at.VaccinationId });
            modelBuilder.Entity<AnimalVaccination>()
                .HasOne(a => a.Animal)
                .WithMany(at => at.AnimalVaccinations)
                .HasForeignKey(a => a.AnimalId);
            modelBuilder.Entity<AnimalVaccination>()
                .HasOne(at => at.Vaccination)
                .WithMany(a => a.AnimalVaccinations)
                .HasForeignKey(at => at.VaccinationId);

            modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Dog"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Cat"
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Others"
                    }
            );
            modelBuilder.Entity<Address>().HasData(
                    new Address
                    {
                        Id = 1,
                        Name = "Berlin"
                    },
                    new Address
                    {
                        Id = 2,
                        Name = "Hamburg"
                    },
                    new Address
                    {
                        Id = 3,
                        Name = "Munich"
                    },
                    new Address
                    {
                        Id = 4,
                        Name = "Cologne"
                    },
                    new Address
                    {
                        Id = 5,
                        Name = "Frankfurt"
                    },
                    new Address
                    {
                        Id = 6,
                        Name = "Stuttgart"
                    },
                    new Address
                    {
                        Id = 7,
                        Name = "Dusseldorf"
                    },
                    new Address
                    {
                        Id = 8,
                        Name = "Dortmund"
                    },
                    new Address
                    {
                        Id = 9,
                        Name = "Essen"
                    },
                    new Address
                    {
                        Id = 10,
                        Name = "Leipzig"
                    }
            );
            modelBuilder.Entity<Food>().HasData(
                    new Food
                    {
                        Id = 1,
                        Name = "Premium feed"
                    },
                    new Food
                    {
                        Id = 2,
                        Name = "Medical feed"
                    },
                    new Food
                    {
                        Id = 3,
                        Name = "Natural feed"
                    }
            );
            modelBuilder.Entity<Animal>().HasData(
                    new Animal
                    {
                        Id = 2,
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

            modelBuilder.Entity<Vaccination>().HasData(
                    new Vaccination
                    {
                        Id = 1,
                        Type = "Common",
                        Name = "Daramoon"
                    },
                    new Vaccination
                    {
                        Id = 2,
                        Type = "Common",
                        Name = "Vangard"
                    },
                    new Vaccination
                    {
                        Id = 3,
                        Type = "Common",
                        Name = "Nobivak"
                    },
                    new Vaccination
                    {
                        Id = 4,
                        Type = "Rabies vaccine",
                        Name = "Rabisin"
                    },
                    new Vaccination
                    {
                        Id = 5,
                        Type = "Rabies vaccine",
                        Name = "Rabistar"
                    }
            );

            modelBuilder.Entity<Processing>().HasData(
                    new Processing
                    {
                        Id = 1,
                        Type = "Anti-flea and anti-ticks processing"
                    },
                    new Processing
                    {
                        Id = 2,
                        Type = "Anti-worms processing"
                    }
                );

            modelBuilder.Entity<Defect>().HasData(
                    new Defect
                    {
                        Id = 1,
                        Type = "Front pow disability"
                    },
                    new Defect
                    {
                        Id = 2,
                        Type = "Back pow disability"
                    },
                    new Defect
                    {
                        Id = 3,
                        Type = "Vision disability"
                    },
                    new Defect
                    {
                        Id = 4,
                        Type = "Hearing disability"
                    }
                );

            modelBuilder.Entity<AttitudeTo>().HasData(
                    new AttitudeTo
                    {
                        Id = 1,
                        Name = "Adults"
                    },
                    new AttitudeTo
                    {
                        Id = 2,
                        Name = "Childrens"
                    },
                    new AttitudeTo
                    {
                        Id = 3,
                        Name = "Cats"
                    },
                    new AttitudeTo
                    {
                        Id = 4,
                        Name = "Dogs"
                    }
                );

            modelBuilder.Entity<Needs>().HasData(
                    new Needs
                    {
                        Id = 1,
                        Name = "Need to be housed with other animals"
                    },
                    new Needs
                    {
                        Id = 2,
                        Name = "Need to be housed apart from other animals"
                    },
                    new Needs
                    {
                        Id = 3,
                        Name = "Need for a suitable diet"
                    }
                );

            modelBuilder.Entity<Keeping>().HasData(
                    new Keeping
                    {
                        Id = 1,
                        Name = "Flat"
                    },
                    new Keeping
                    {
                        Id = 2,
                        Name = "Enclosed house with yard"
                    },
                    new Keeping
                    {
                        Id = 3,
                        Name = "Wintering only in the house"
                    }
                );

            modelBuilder.Entity<AnimalVaccination>().HasData(
                    new AnimalVaccination
                    {
                        AnimalId = 2,
                        VaccinationId = 3,
                        VaccinationDate = DateTime.Parse("12/11/2019"),
                        NextVaccinationDate = DateTime.Parse("12/11/2020")
                    },
                    new AnimalVaccination
                    {
                        AnimalId = 2,
                        VaccinationId = 4,
                        VaccinationDate = DateTime.Parse("22/11/2019"),
                        NextVaccinationDate = DateTime.Parse("22/11/2020")
                    },
                    new AnimalVaccination
                    {
                        AnimalId = 3,
                        VaccinationId = 2,
                        VaccinationDate = DateTime.Parse("9/11/2019"),
                        NextVaccinationDate = DateTime.Parse("9/11/2020")
                    },
                    new AnimalVaccination
                    {
                        AnimalId = 5,
                        VaccinationId = 1,
                        VaccinationDate = DateTime.Parse("22/06/2018"),
                        NextVaccinationDate = DateTime.Parse("22/06/2019")
                    },
                    new AnimalVaccination
                    {
                        AnimalId = 5,
                        VaccinationId = 3,
                        VaccinationDate = DateTime.Parse("22/06/2019"),
                        NextVaccinationDate = DateTime.Parse("22/06/2020")
                    },
                    new AnimalVaccination
                    {
                        AnimalId = 5,
                        VaccinationId = 5,
                        VaccinationDate = DateTime.Parse("22/07/2019"),
                        NextVaccinationDate = DateTime.Parse("22/07/2020")
                    }
                );

            modelBuilder.Entity<AnimalProcessing>().HasData(
                    new AnimalProcessing
                    {
                        AnimalId = 7,
                        ProcessingId = 1,
                        ProcessingDate = DateTime.Parse("12/08/2019"),
                        NextProcessingDate = DateTime.Parse("12/01/2020")
                    },
                    new AnimalProcessing
                    {
                        AnimalId = 4,
                        ProcessingId = 2,
                        ProcessingDate = DateTime.Parse("13/02/2019"),
                        NextProcessingDate = DateTime.Parse("13/08/2019")
                    },
                    new AnimalProcessing
                    {
                        AnimalId = 8,
                        ProcessingId = 2,
                        ProcessingDate = DateTime.Parse("9/11/2019"),
                        NextProcessingDate = DateTime.Parse("9/11/2020")
                    },
                    new AnimalProcessing
                    {
                        AnimalId = 11,
                        ProcessingId = 1,
                        ProcessingDate = DateTime.Parse("06/06/2018"),
                        NextProcessingDate = DateTime.Parse("06/12/2019")
                    },
                    new AnimalProcessing
                    {
                        AnimalId = 11,
                        ProcessingId = 2,
                        ProcessingDate = DateTime.Parse("06/12/2019"),
                        NextProcessingDate = DateTime.Parse("06/06/2020")
                    },
                    new AnimalProcessing
                    {
                        AnimalId = 9,
                        ProcessingId = 2,
                        ProcessingDate = DateTime.Parse("02/02/2019"),
                        NextProcessingDate = DateTime.Parse("02/02/2020")
                    }
               );

            modelBuilder.Entity<AnimalDefects>().HasData(
                     new AnimalDefects
                     {
                         AnimalId = 13,
                         DefectsId = 1
                     },
                     new AnimalDefects
                     {
                         AnimalId = 10,
                         DefectsId = 2
                     },
                     new AnimalDefects
                     {
                         AnimalId = 8,
                         DefectsId = 1
                     },
                     new AnimalDefects
                     {
                         AnimalId = 11,
                         DefectsId = 4,
                     }
                 );

            modelBuilder.Entity<AnimalAttitudeTo>().HasData(
                   new AnimalAttitudeTo
                   {
                       AnimalId = 4,
                       AttitudeId = 1,
                       Mark = 3
                   },
                   new AnimalAttitudeTo
                   {
                       AnimalId = 2,
                       AttitudeId = 2,
                       Mark = 3
                   },
                   new AnimalAttitudeTo
                   {
                       AnimalId = 12,
                       AttitudeId = 1,
                       Mark = 3
                   },
                   new AnimalAttitudeTo
                   {
                       AnimalId = 11,
                       AttitudeId = 4,
                       Mark = 2
                   },
                   new AnimalAttitudeTo
                   {
                       AnimalId = 11,
                       AttitudeId = 1,
                       Mark = 5
                   },
                   new AnimalAttitudeTo
                   {
                       AnimalId = 11,
                       AttitudeId = 3,
                       Mark = 4
                   }
               );

            modelBuilder.Entity<AnimalNeeds>().HasData(
                  new AnimalNeeds
                  {
                      AnimalId = 2,
                      NeedsId = 3
                  },
                  new AnimalNeeds
                  {
                      AnimalId = 2,
                      NeedsId = 2
                  },
                  new AnimalNeeds
                  {
                      AnimalId = 3,
                      NeedsId = 1
                  },
                  new AnimalNeeds
                  {
                      AnimalId = 7,
                      NeedsId = 3
                  },
                  new AnimalNeeds
                  {
                      AnimalId = 8,
                      NeedsId = 2
                  },
                  new AnimalNeeds
                  {
                      AnimalId = 14,
                      NeedsId = 1
                  }
              );

            modelBuilder.Entity<AnimalKeeping>().HasData(
                  new AnimalKeeping
                  {
                      AnimalId = 2,
                      KeepingId = 3
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 2,
                      KeepingId = 1
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 3,
                      KeepingId = 3
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 4,
                      KeepingId = 2
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 5,
                      KeepingId = 1
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 6,
                      KeepingId = 2
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 7,
                      KeepingId = 1
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 8,
                      KeepingId = 2
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 9,
                      KeepingId = 1
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 10,
                      KeepingId = 2
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 11,
                      KeepingId = 1
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 12,
                      KeepingId = 2
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 12,
                      KeepingId = 1
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 13,
                      KeepingId = 1
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 14,
                      KeepingId = 2
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 15,
                      KeepingId = 1
                  },
                  new AnimalKeeping
                  {
                      AnimalId = 16,
                      KeepingId = 1
                  }
              );
        }

    }
}
