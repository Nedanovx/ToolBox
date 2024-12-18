using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Net;
using ToolBox.Infrastructure.Models;

namespace ToolBox.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<ProductSubCategory>()
        .HasKey(ps => new { ps.ProductId, ps.SubCategoryId });

            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<SubCategory> SubCategories { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
        public DbSet<ProductSubCategory> ProductSubCategories { get; set; } = null!;
        public DbSet<DeliveryAddress> DeliveryAddresses { get; set; } = null!;
        public DbSet<Cart> Carts { get; set; } = null!;
        public DbSet<CartItem> CartItems { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrdersItem { get; set; } = null!;
    }
}
