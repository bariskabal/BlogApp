using BlogApp.DTO.DTOs.CategoryDtos;
using FluentValidation;

namespace BlogApp.Business.ValidationRules.FluentValidation
{
    public class CategoryAddValidator : AbstractValidator<CategoryAddDto>
    {
        public CategoryAddValidator()
        {
            RuleFor(I=>I.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
        }
    }
}