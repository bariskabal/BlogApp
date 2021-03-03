using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.DataAccess.Concrete.EFCore.Context;
using BlogApp.DataAccess.Interface;
using BlogApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.DataAccess.Concrete.EFCore.Repositories
{
    public class EFCategoryRepository : EFGenericRepository<Category>, ICategoryDal
    {
        private readonly BlogAppContext _context;
        public EFCategoryRepository(BlogAppContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            return await _context.Categories.OrderByDescending(I=>I.Id).Include(I=>I.CategoryBlogs).ToListAsync();
        }
    }
}