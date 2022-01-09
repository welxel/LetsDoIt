using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppCore.Business.List;
using AppCore.Business.Models.Results;
using AppCore.Business.Services.Bases;
using Business.Models;

namespace Business.Services.Bases
{
    public interface IUserFriendService : IService<UserFirendModel>
    {
        public Result<IEnumerable<UserFirendModel>> GetRequestFriend(int idUser);
        public void FlagChange(int idUserRequest,bool isSuccess);
        public Result<IEnumerable<UserFirendModel>> UserFriendList(int idUser);
    }
}
