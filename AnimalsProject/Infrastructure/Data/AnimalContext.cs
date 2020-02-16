using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Infrastructure.Data.ModelConfigurations;


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

            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new FoodConfiguration());
            modelBuilder.ApplyConfiguration(new AnimalConfiguration());
            modelBuilder.ApplyConfiguration(new VaccinationConfiguration());
            modelBuilder.ApplyConfiguration(new ProcessingConfiguration());
            modelBuilder.ApplyConfiguration(new DefectConfiguration());
            modelBuilder.ApplyConfiguration(new AttitudeToConfiguration());
            modelBuilder.ApplyConfiguration(new NeedsConfiguration());
            modelBuilder.ApplyConfiguration(new KeepingConfiguration());
            modelBuilder.ApplyConfiguration(new AnimalAttitudeToConfiguration());
            modelBuilder.ApplyConfiguration(new AnimalDefectsConfiguration());
            modelBuilder.ApplyConfiguration(new AnimalKeepingConfiguration());
            modelBuilder.ApplyConfiguration(new AnimalNeedsConfiguration());
            modelBuilder.ApplyConfiguration(new AnimalProcessingConfiguration());
            modelBuilder.ApplyConfiguration(new AnimalVaccinationConfiguration());
        }

    }
}
