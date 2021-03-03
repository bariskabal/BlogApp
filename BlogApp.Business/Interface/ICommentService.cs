using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApp.Entity.Concrete;

namespace BlogApp.Business.Interface
{
    public interface ICommentService : IGenericService<Comment>
    {
        Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId);
    }
}