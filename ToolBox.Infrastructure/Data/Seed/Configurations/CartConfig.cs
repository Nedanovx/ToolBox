using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Infrastructure.Models;

namespace ToolBox.Infrastructure.Data.Seed.Configurations
{
    internal class CartConfig : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            var data = new SeedData();

            builder.HasData(new Cart[] { data.Cart1, data.Cart2 });
        }
    }
}
