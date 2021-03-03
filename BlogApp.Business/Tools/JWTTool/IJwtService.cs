using BlogApp.Entity.Concrete;

namespace BlogApp.Business.Tools.JWTTool
{
    public interface IJwtService
    {
         JwtToken GenerateJwt(AppUser appUser);
    }
}