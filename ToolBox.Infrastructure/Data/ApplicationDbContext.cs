using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToolBox.Infrastructure.Data.Seed.Configurations;
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

            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string> { RoleId = "10acf0fb-c86b-4559-9eee-1febe790886e", UserId = "79b8a2fa-0fd5-4d3a-ab98-4d7093728c14" },
            new IdentityUserRole<string> { RoleId = "f8a9f603-046f-4257-a5c6-95019dca99e9", UserId = "6331660a-cf01-4033-8642-8774887bc271" },
            new IdentityUserRole<string> { RoleId = "f8a9f603-046f-4257-a5c6-95019dca99e9", UserId = "0dd13f6c-918d-4e39-bf80-5874a9c96b08" });

            builder.ApplyConfiguration(new RoleConfig());
            builder.ApplyConfiguration(new AdminConfig());
            builder.ApplyConfiguration(new UserConfig());
            builder.ApplyConfiguration(new CategoryConfig());
            builder.ApplyConfiguration(new SubCategoryConfig());
            builder.ApplyConfiguration(new ProductConfig());
            builder.ApplyConfiguration(new ProductSubCategoryConfig());
            builder.ApplyConfiguration(new CommentConfig());
            builder.ApplyConfiguration(new CartConfig());
            
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
        public DbSet<OrderItem> OrderItems { get; set; } = null!;
    }
}
