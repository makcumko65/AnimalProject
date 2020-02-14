using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AnimalContext : DbContext
    {
        public AnimalContext(DbContextOptions options) : base(options){}

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
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
        }

    }
}
