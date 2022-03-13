using AppCore.Business.Models.Results;
using Business.Models.MobilAppModel;
using Business.Services.Bases.MobillAppBase;
using DataAccess.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Business.Services.MobilAppServices
{
    public class LoginService :ILoginService
    {
        private readonly UserRepositoryBase _userRepositoryBase;

        private readonly AppSettings _appSettings;
        public LoginService(UserRepositoryBase userRepository, IOptions<AppSettings> appSettings)
        {
            _userRepositoryBase = userRepository;
            _appSettings = appSettings.Value;
        }


        public Result<LoginModel> JWTLogin(string email, string password)
        {
            var result = _userRepositoryBase.GetEntityQuery().Include(x => x.UserDetail).Include(x=>x.City).Include(x=>x.Town).Where(x => x.UserDetail.Email == email && x.Password == password)
                .Select(x=> new LoginModel() {
            Name=x.UserName,
            Id=x.Id,
            
            }).FirstOrDefault();
            if (result==null)
            {
                return new ErrorResult<LoginModel>("Kullanıcı bulunamadı.",result);
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, result.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            result.Token = tokenHandler.WriteToken(token);
            return new SuccessResult<LoginModel>("Authanticate is success",result);
        } 
    }
}



