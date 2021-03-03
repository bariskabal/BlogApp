using System;
using System.Collections.Generic;
using BlogApp.Entity.Interface;

namespace BlogApp.Entity.Concrete
{
    public class Blog : ITable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime PostedTime { get; set; } = DateTime.Now;
        public List<CategoryBlog> CategoryBlogs  { get; set; }
        public List<Comment> Comments { get; set; }

       
    }
}