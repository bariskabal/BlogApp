using BlogApp.DataAccess.Concrete.EFCore.Mapping;
using BlogApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlogApp.DataAccess.Concrete.EFCore.Context
{
    public class BlogAppContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public BlogAppContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("db1"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new BlogMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CategoryBlogMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryBlog> CategoryBlogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}