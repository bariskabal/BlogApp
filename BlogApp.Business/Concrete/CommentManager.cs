using System.Collections.Generic;
using System.Threading.Tasks;
using BlogApp.Business.Interface;
using BlogApp.DataAccess.Interface;
using BlogApp.Entity.Concrete;

namespace BlogApp.Business.Concrete
{
    public class CommentManager : GenericManager<Comment>,ICommentService
    {
        
        private readonly  ICommentDal _commentDal;
        public CommentManager(IGenericDal<Comment> genericDal,ICommentDal commentDal) : base(genericDal)
        {
            _commentDal = commentDal;
            
        }

        public Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId)
        {
            return _commentDal.GetAllWithSubCommentsAsync(blogId,parentId);
        }
    }
}