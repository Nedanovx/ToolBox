using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ToolBox.Infrastructure.Models;

namespace ToolBox.Infrastructure.Data.Seed.Configurations
{
    internal class ProductSubCategoryConfig : IEntityTypeConfiguration<ProductSubCategory>
    {
        public void Configure(EntityTypeBuilder<ProductSubCategory> builder)
        {
            var data = new SeedData();

            builder.HasData(new ProductSubCategory[] { data.ProductSubCategory1, data.ProductSubCategory2, data.ProductSubCategory3,
            data.ProductSubCategory4, data.ProductSubCategory5, data.ProductSubCategory6, data.ProductSubCategory7,
             data.ProductSubCategory8, data.ProductSubCategory9, data.ProductSubCategory10, data.ProductSubCategory11,
             data.ProductSubCategory12, data.ProductSubCategory13, data.ProductSubCategory14,
            data.ProductSubCategory15, data.ProductSubCategory16, data.ProductSubCategory17,
            data.ProductSubCategory18});
        }
    }


}
