using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AnimalContext context;

        public Repository(AnimalContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
            await SaveAsync();
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await context.Set<TEntity>().AddRangeAsync(entities);
            await SaveAsync();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async ValueTask<TEntity> GetByIdAsync(long id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task Remove(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
            await SaveAsync();
        }

        public async Task RemoveRange(IEnumerable<TEntity> entities)
        {
            context.Set<TEntity>().RemoveRange(entities);
            await SaveAsync();
        }

        public async ValueTask<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await context.Set<TEntity>().SingleOrDefaultAsync(predicate);
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public async Task Update(TEntity obj)
        {
            context.Set<TEntity>().Update(obj);
            await SaveAsync();
        }

        public DbSet<TEntity> Entities => context.Set<TEntity>();
    }
}