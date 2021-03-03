using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApp.Entity.Concrete;

namespace BlogApp.DataAccess.Interface
{
    public interface IBlogDal : IGenericDal<Blog>
    {
         Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId);
         Task<List<Category>> GetCategoriesAsync(int blogId);
         Task<List<Blog>> GetLastFiveAsync();
    }
}