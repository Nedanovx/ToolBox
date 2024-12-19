namespace ToolBox.Infrastructure.Common
{
    public interface IRepository
    {
        IQueryable<T> AllAsync<T>() where T : class;
    }
}
