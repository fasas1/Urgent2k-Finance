﻿using System.Diagnostics;
using System.Linq.Expressions;

namespace Urgent_2k_Finance.Repository.IRepository
{
    public interface IRepository<T> where T : class
    { 
        Task<T>GetAsync(Expression <Func<T, bool>>? filter = null, bool tracked =true, string? includeProperties = null);
        Task<List<T>> GetAllAsync(Expression <Func<T, bool>>? filter = null,  bool tracked = true, string? includeProperties = null);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task FindAsync(T entity);
        Task SaveAsync();

    }
}
