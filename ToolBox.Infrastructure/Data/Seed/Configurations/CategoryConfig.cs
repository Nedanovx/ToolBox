using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ToolBox.Infrastructure.Models;

namespace ToolBox.Infrastructure.Data.Seed.Configurations
{
    internal class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new SeedData();

            builder.HasData(new Category[] { data.Category, data.Category1 });
        }
    }
}
