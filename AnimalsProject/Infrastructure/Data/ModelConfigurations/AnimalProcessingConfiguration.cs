using System;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.ModelConfigurations
{
    public class AnimalProcessingConfiguration : IEntityTypeConfiguration<AnimalProcessing>
    {
        public void Configure(EntityTypeBuilder<AnimalProcessing> builder)
        {
            builder.HasKey(at => new { at.AnimalId, at.ProcessingId });
            
            builder.HasOne(a => a.Animal)
                .WithMany(at => at.AnimalProcessings)
                .HasForeignKey(a => a.AnimalId);
            
            builder.HasOne(at => at.Processing)
                .WithMany(a => a.AnimalProcessings)
                .HasForeignKey(at => at.ProcessingId);

            DataSeedConfigure(builder);
        }

        private void DataSeedConfigure(EntityTypeBuilder<AnimalProcessing> builder)
        {
            builder.HasData(
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
        }
    }
}
