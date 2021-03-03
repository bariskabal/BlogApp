using System.Threading.Tasks;
using BlogApp.Business.Interface;
using BlogApp.DataAccess.Interface;
using BlogApp.DTO.DTOs.AppUserDtos;
using BlogApp.Entity.Concrete;

namespace BlogApp.Business.Concrete
{
    public class AppUserManager : GenericManager<AppUser>,IAppUserService
    {
        private readonly IGenericDal<AppUser> _genericDal;
        public AppUserManager(IGenericDal<AppUser> genericDal) :base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto)
        {
            return await _genericDal.GetAsync(I=>I.UserName == appUserLoginDto.UserName && I.Password == appUserLoginDto.Password);
        }

        public async Task<AppUser> FindByNameAsync(string userName)
        {
            return await _genericDal.GetAsync(I=>I.UserName == userName);
            
        }
    }
}