using BlogApp.DTO.DTOs.CategoryBlogDtos;
using BlogApp.Entity.Concrete;
using FluentValidation;

namespace BlogApp.Business.ValidationRules.FluentValidation
{
    public class CategoryBlogValidator : AbstractValidator<CategoryBlogDto>
    {
        public CategoryBlogValidator()
        {
            RuleFor(I=>I.CategoryId).InclusiveBetween(0,int.MaxValue).WithMessage("Category id boş geçilemez");
            RuleFor(I=>I.BlogId).InclusiveBetween(0,int.MaxValue).WithMessage("Blog id boş geçilemez");
        }
    }
}