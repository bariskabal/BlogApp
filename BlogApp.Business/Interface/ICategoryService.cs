using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApp.Entity.Concrete;

namespace BlogApp.Business.Interface
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task<List<Category>> GetAllSortedByIdAsync();
        Task<List<Category>> GetAllWithCategoryBlogsAsync();
    }
}