using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(
                new IdentityUser
                {
                    Id = "1",
                    Email = "pets.adoption.service@gmail.com",
                    NormalizedEmail = "PETS.ADOPTION.SERVICE@GMAIL.COM"
                });
        }
    }
}
