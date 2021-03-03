using System.Threading.Tasks;
using BlogApp.DTO.DTOs.AppUserDtos;
using BlogApp.Entity.Concrete;

namespace BlogApp.Business.Interface
{
    public interface IAppUserService : IGenericService<AppUser>
    {
         Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto);
         Task<AppUser> FindByNameAsync(string userName);
    }
}