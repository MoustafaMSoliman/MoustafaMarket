﻿using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.Common.Persistence;

public interface IRepository<T> where T : class
{
    Task<T?> GetByIdAsync(object id);
   
    Task<IEnumerable<T>> GetAllAsync();
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
}
