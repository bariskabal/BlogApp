using BlogApp.DataAccess.Concrete.EFCore.Context;
using BlogApp.DataAccess.Interface;
using BlogApp.Entity.Concrete;

namespace BlogApp.DataAccess.Concrete.EFCore.Repositories
{
    public class EFAppUserRepository : EFGenericRepository<AppUser>,IAppUserDal
    {
        public EFAppUserRepository(BlogAppContext context) : base(context)
        {
        }
    }
}