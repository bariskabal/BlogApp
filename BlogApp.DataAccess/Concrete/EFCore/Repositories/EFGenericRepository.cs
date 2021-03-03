using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BlogApp.DataAccess.Concrete.EFCore.Context;
using BlogApp.DataAccess.Interface;
using BlogApp.Entity.Interface;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.DataAccess.Concrete.EFCore.Repositories
{
    public class EFGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, ITable, new()
    {
        private readonly BlogAppContext _context;
        public EFGenericRepository(  BlogAppContext context)
        {
            _context = context;
        }
        public async Task AddAsync(TEntity entity)
        {
           
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
            
            return await _context.FindAsync<TEntity>(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {

            return await _context.Set<TEntity>().Where(filter).ToListAsync();
        }
         public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter,Expression<Func<TEntity,TKey>> keySelector)
        {

            return await _context.Set<TEntity>().Where(filter).OrderByDescending(keySelector).ToListAsync();
        }
         public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity,TKey>> keySelector)
        {

            return await _context.Set<TEntity>().OrderByDescending(keySelector).ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {

            return await _context.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task RemoveAsync(TEntity entity)
        {

            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {

            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}