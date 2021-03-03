using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApp.Entity.Concrete;

namespace BlogApp.DataAccess.Interface
{
    public interface ICategoryDal : IGenericDal<Category>
    {
         Task<List<Category>> GetAllWithCategoryBlogsAsync();
    }
}