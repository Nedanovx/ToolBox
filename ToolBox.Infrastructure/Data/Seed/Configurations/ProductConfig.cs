using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using ToolBox.Infrastructure.Models;

namespace ToolBox.Infrastructure.Data.Seed.Configurations
{
    internal class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var data = new SeedData();

            builder.HasData(new Product[] { data.Product1, data.Product2, data.Product3,
            data.Product4, data.Product5, data.Product6, data.Product7, data.Product8,
            data.Product9, data.Product10, data.Product11, data.Product12, data.Product13,
            data.Product14, data.Product15, data.Product16, data.Product17} );
        }
    }
}
