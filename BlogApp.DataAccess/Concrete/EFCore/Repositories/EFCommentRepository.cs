using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.DataAccess.Concrete.EFCore.Context;
using BlogApp.DataAccess.Interface;
using BlogApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.DataAccess.Concrete.EFCore.Repositories
{
    public class EFCommentRepository : EFGenericRepository<Comment>, ICommentDal
    {
        private readonly BlogAppContext _context;
        public EFCommentRepository(BlogAppContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId)
        {
            List<Comment> result = new List<Comment>();
            await GetComments(blogId,parentId,result);
            return result;
        }
        private async Task GetComments(int blogId, int? parentId,List<Comment> result)
        {
            var comments = await _context.Comments.Where(I=>I.BlogId==blogId && I.ParentCommentId == parentId).OrderByDescending(I=>I.PostedTime).ToListAsync();
            if (comments.Count>0)
            {
                foreach (var item in comments)
                {
                    if(item.SubComments==null)
                    {
                        item.SubComments = new List<Comment>();
                    }
                    await GetComments(item.BlogId,item.Id,item.SubComments);
                    if(!result.Contains(item))
                    {
                        result.Add(item);
                    }
                }
            }
        }
    }
}