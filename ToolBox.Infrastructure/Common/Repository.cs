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
    }
}
