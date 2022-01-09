using AppCore.Business.Models.Results;
using AppCore.Business.Services.Bases;
using Business.Models.MobilAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Services.Bases.MobillAppBase
{
    public interface ILoginService
    {
        Result<LoginModel> JWTLogin(string email, string password);
    }
}
