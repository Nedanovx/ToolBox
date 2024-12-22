using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ToolBox.Core.Contracts;
using ToolBox.Core.Services;
using ToolBox.Infrastructure.Common;
using ToolBox.Infrastructure.Data;
using ToolBox.Infrastructure.Models;
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IDetailService, DetailService>();
            services.AddScoped<ISearchService, SearchService>();
            services.AddScoped<ICommentService, CommentService>();
			return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

			services.AddScoped<IRepository, Repository>();

			return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredLength = 6;
            })
           .AddRoles<IdentityRole>()
           .AddEntityFrameworkStores<ApplicationDbContext>()
           .AddDefaultUI()
           .AddDefaultTokenProviders();

            return services;
        }
    }
}