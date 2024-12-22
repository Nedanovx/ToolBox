﻿namespace ToolBox.Infrastructure.Common
{
    public interface IRepository
    {
        IQueryable<T> AllAsync<T>() where T : class;
        Task AddAsync<T>(T entity) where T : class;
        Task<int> SavaChangesAsync();
    }
}
