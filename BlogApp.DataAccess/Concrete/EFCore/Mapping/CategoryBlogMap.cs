using BlogApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApp.DataAccess.Concrete.EFCore.Mapping
{
    public class CategoryBlogMap : IEntityTypeConfiguration<CategoryBlog>
    {
        public void Configure(EntityTypeBuilder<CategoryBlog> builder)
        {
            builder.HasKey(I=>I.Id);
            builder.Property(I=>I.Id).UseIdentityColumn();

            builder.HasIndex(I=> new {I.BlogId,I.CategoryId}).IsUnique();            
        }
    }
}