using AppCore.Business.Models.Results;
using AppCore.Business.Services.Bases;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IUserService:IService<UserRegisterModel>
    {
        Result UpdatePassword(UserRegisterModel userRegisterModel);
        Result<UserRegisterModel> getUserById(int id);
        Result<List<UserRegisterModel>> GetFilterUser(int id);
    }
}
