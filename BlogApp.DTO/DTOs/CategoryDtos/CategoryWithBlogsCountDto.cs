using BlogApp.Entity.Concrete;

namespace BlogApp.DTO.DTOs.CategoryDtos
{
    public class CategoryWithBlogsCountDto
    {
        public int BlogsCount { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        
    }
}