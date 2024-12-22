using Microsoft.EntityFrameworkCore;
using ToolBox.Infrastructure.Data;

namespace ToolBox.Infrastructure.Common
{
    public class Repository : IRepository
    {
        private readonly DbContext context;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
        }

        private DbSet<T> DbSet<T>() where T : class
        {
            return context.Set<T>();
        }
        public IQueryable<T> AllAsync<T>() where T : class
        {
            return DbSet<T>();
        }
        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        public async Task<int> SavaChangesAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
