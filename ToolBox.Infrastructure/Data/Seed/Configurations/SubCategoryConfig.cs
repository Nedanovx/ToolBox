using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ToolBox.Infrastructure.Models;

namespace ToolBox.Infrastructure.Data.Seed.Configurations
{
    internal class SubCategoryConfig : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            var data = new SeedData();

            builder.HasData(new SubCategory[] { data.SubCategory, data.SubCategory1, data.SubCategory2,
                                                data.SubCategory3, data.SubCategory4, data.SubCategory5,
                                                data.SubCategory6, data.SubCategory7 });
        }
    }
}
