using System;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.ModelConfigurations
{
    public class AnimalVaccinationConfiguration : IEntityTypeConfiguration<AnimalVaccination>
    {
        public void Configure(EntityTypeBuilder<AnimalVaccination> builder)
        {
            builder.HasKey(at => new { at.AnimalId, at.VaccinationId });
            
            builder.HasOne(a => a.Animal)
                .WithMany(at => at.AnimalVaccinations)
                .HasForeignKey(a => a.AnimalId);
            
            builder.HasOne(at => at.Vaccination)
                .WithMany(a => a.AnimalVaccinations)
                .HasForeignKey(at => at.VaccinationId);

            builder.Property(av => av.AnimalId).IsRequired();
            builder.Property(av => av.VaccinationId).IsRequired();
            builder.Property(av => av.VaccinationDate).IsRequired();
            builder.Property(av => av.NextVaccinationDate).IsRequired();

            DataSeedConfigure(builder);
        }

        private void DataSeedConfigure(EntityTypeBuilder<AnimalVaccination> builder)
        {
            builder.HasData(
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
        }
    }
}
