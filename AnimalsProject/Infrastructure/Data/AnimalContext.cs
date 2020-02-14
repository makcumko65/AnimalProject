using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Data
{
    public class AnimalContext : DbContext
    {
        public AnimalContext(DbContextOptions options) : base(options){}

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
                        CategotyId = 2,
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
                        CategotyId = 1,
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
                        CategotyId = 3,
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
                        CategotyId = 1,
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
                        CategotyId = 2,
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
                        CategotyId = 1,
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
                        CategotyId = 1,
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
                        IsAdopted = true,
                    }
            );
        }

    }
}
