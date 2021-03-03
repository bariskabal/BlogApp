using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApp.Entity.Concrete;

namespace BlogApp.DataAccess.Interface
{
    public interface ICommentDal : IGenericDal<Comment>
    {
         Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId,int? parentId);
    }
}