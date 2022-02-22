using EFProjectTwo.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using EFProjectTwo.Data.Contexts;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace EFProjectTwo.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DbContext _dbContext;
        private DbSet<T> _dbSet;

        public GenericRepository()
        {
            _dbContext = new NajotTalimDbContext();
            _dbSet = _dbContext.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            var entry = await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entry.Entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            var entry = _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();

            return entry.Entity;
        }

        public Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            return (Task<IQueryable<T>>)(predicate == null ? _dbSet : _dbSet.Where(predicate));
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefaultAsync(predicate);
        }
            
        public async Task<T> UpdateAsync(T entity)
        {
            var entry = _dbSet.Update(entity);

            await _dbContext.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
