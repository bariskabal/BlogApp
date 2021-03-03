using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BlogApp.Business.StringInfos;
using BlogApp.Entity.Concrete;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BlogApp.Business.Tools.JWTTool
{
    public class JwtManager : IJwtService
    {
        private readonly IOptions<JwtInfo> _optionsJwt;
        public JwtManager(IOptions<JwtInfo> optionsJwt)
        {
            _optionsJwt = optionsJwt;
        }
        public JwtToken GenerateJwt(AppUser appUser)
        {
            var jwtInfo = _optionsJwt.Value;
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtInfo.SecurityKey));
            SigningCredentials signInCredentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer:jwtInfo.Issuer,audience:jwtInfo.Audience,claims:SetClaims(appUser),notBefore:DateTime.Now,expires:DateTime.Now.AddMinutes(jwtInfo.Expires),signingCredentials:signInCredentials);
            JwtToken jwtToken = new JwtToken();
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            jwtToken.Token = handler.WriteToken(jwtSecurityToken); 
            return jwtToken;
        }
        private List<Claim> SetClaims(AppUser appUser)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name,appUser.UserName));
            claims.Add(new Claim(ClaimTypes.NameIdentifier,appUser.Id.ToString()));
            return claims;
        }
    }
}