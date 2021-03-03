using BlogApp.DTO.DTOs.AppUserDtos;
using FluentValidation;

namespace BlogApp.Business.ValidationRules.FluentValidation
{
    public class AppUserLoginValidator : AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginValidator()
        {
            RuleFor(I=>I.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(I=>I.Password).NotEmpty().WithMessage("Parola boş geçilemez");
        }
    }
}