using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.ModelConfigurations
{
    public class ProcessingConfiguration : IEntityTypeConfiguration<Processing>
    {
        public void Configure(EntityTypeBuilder<Processing> builder)
        {
            DataSeedConfigure(builder);
        }

        private void DataSeedConfigure(EntityTypeBuilder<Processing> builder)
        {
            builder.HasData(
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
        }
    }
}
