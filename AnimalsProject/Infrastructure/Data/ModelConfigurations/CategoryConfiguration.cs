using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.ModelConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            DataSeedConfigure(builder);
        }

        private void DataSeedConfigure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
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
        }
    }  
}
