using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.ModelConfigurations
{
    class AttitudeToConfiguration : IEntityTypeConfiguration<AttitudeTo>
    {
        public void Configure(EntityTypeBuilder<AttitudeTo> builder)
        {
            DataSeedConfigure(builder);
        }

        private void DataSeedConfigure(EntityTypeBuilder<AttitudeTo> builder)
        {
            builder.HasData(
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
        }
    }
}
