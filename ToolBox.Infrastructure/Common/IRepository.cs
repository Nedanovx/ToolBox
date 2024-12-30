namespace ToolBox.Infrastructure.Common
{
    public interface IRepository
    {
        IQueryable<T> AllAsync<T>() where T : class;
        Task AddAsync<T>(T entity) where T : class;
        Task<int> SaveChangesAsync();
        Task<T?> GetByIdAsync<T>(object id) where T : class;
        Task RemoveAsync<T>(T entity) where T : class;
    }
}
