using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BlogApp.Entity.Interface;

namespace BlogApp.Business.Interface
{
    public interface IGenericService<TEntity> where TEntity : class,ITable,new()
    {
         Task<List<TEntity>> GetAllAsync();
         Task<TEntity> FindByIdAsync(int id);
         Task AddAsync(TEntity entity);
         Task UpdateAsync(TEntity entity);
         Task RemoveAsync(TEntity entity);
    }
}