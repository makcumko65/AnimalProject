﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ValueTask<TEntity> GetByIdAsync(long id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        ValueTask<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        Task AddAsync(TEntity entity);
        Task Update(TEntity obj);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        Task Remove(TEntity entity);

        Task RemoveRange(IEnumerable<TEntity> entities);

        Task SaveAsync();

        DbSet<TEntity> Entities { get; }
    }
}
