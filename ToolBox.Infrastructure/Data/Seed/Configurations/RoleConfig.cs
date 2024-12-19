using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ToolBox.Infrastructure.Data.Seed.Configurations
{
    internal class RoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            var data = new SeedData();

            builder.HasData(new IdentityRole[] { data.UserRole, data.AdminRole });
        }
    }
}

