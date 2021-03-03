using System.Collections.Generic;
using BlogApp.Entity.Interface;

namespace BlogApp.Entity.Concrete
{
    public class Category : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryBlog> CategoryBlogs { get; set; }
    }
}