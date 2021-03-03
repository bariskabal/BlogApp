using BlogApp.DTO.DTOs.CommentDtos;
using FluentValidation;

namespace BlogApp.Business.ValidationRules.FluentValidation
{
    public class CommentAddValidator : AbstractValidator<CommentAddDto>
    {
        public CommentAddValidator()
        {
            RuleFor(I=>I.AuthorName).NotEmpty().WithMessage("Ad alanı boş bırakılamaz");
            RuleFor(I=>I.AuthorEmail).NotEmpty().WithMessage("Email alanı boş bırakılamaz");
            RuleFor(I=>I.Description).NotEmpty().WithMessage("Description alanı boş bırakılamaz");
        }    
    }
}