using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppCore.Business.List;
using AppCore.Business.Models.Results;
using Business.Models;
using Business.Services.Bases;
using DataAccess.EntityFramework.Repositories.Bases;
using DataAccess.Repositories.Bases;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Services {
    public class UserFriendService:IUserFriendService
    {
        private readonly UserFriendRepositoryBase _userFriendRepositoryBase;
        private readonly UserRepositoryBase _userRepositoryBase;

        public UserFriendService(UserFriendRepositoryBase userFriendRepositoryBase,UserRepositoryBase userRepositoryBase)
        {
            _userFriendRepositoryBase = userFriendRepositoryBase;
            _userRepositoryBase = userRepositoryBase;
        }

        public void Dispose()
        {
            _userFriendRepositoryBase.Dispose();
        }

        public Result<IQueryable<UserFirendModel>> GetQuery()
        {
            throw new NotImplementedException();
        }

        public Result Add(UserFirendModel model)
        {
            try
            {
                UserFriends userFriends = new UserFriends
                { 
                    Status = model.Status,
                    FormToUserID = model.FormToUserID,
                    IDUser = model.IDUser,
                    CreatedDate = model.CreatedDate
                };
                _userFriendRepositoryBase.Add(userFriends);
                return new SuccessResult();
            }
            catch (Exception exc)
            {
                return new ExceptionResult(exc);
            }
        }

        public Result Update(UserFirendModel model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Result<IEnumerable<UserFirendModel>> GetRequestFriend(int idUser)
        {
            var result = _userFriendRepositoryBase.GetEntityQuery(x => x.FormToUserID == idUser && x.Status==2)
                .Select(e => new UserFirendModel()
                {
                    Id = e.Id,
                    Status = e.Status, 
                    CreatedDate =e.CreatedDate,
                    FormToUserID = e.FormToUserID,
                    IDUser = e.IDUser,
                    User = e.User
                });
            return new SuccessResult<IEnumerable<UserFirendModel>>(result);
        }

        public void FlagChange(int idUserRequest,bool isSuccess)
        {

            var result = _userFriendRepositoryBase.GetEntityQuery().Where(x => x.Id == idUserRequest)
                .Select(e => new UserFirendModel() {
                    Id = e.Id,
                    Status = e.Status,
                    CreatedDate = e.CreatedDate,
                    FormToUserID = e.FormToUserID,
                    IDUser = e.IDUser,
                    User = e.User
                }).FirstOrDefault();
      
            result.Status = isSuccess?1:0;
            var entity = new UserFriends()
            {
                Id = result.Id,
                Status = result.Status,
                User = result.User,
                CreatedDate=result.CreatedDate,
                FormToUserID = result.FormToUserID,
                IDUser = result.IDUser
            };
            _userFriendRepositoryBase.Update(entity);


        }

        public Result<IEnumerable<UserFirendModel>> UserFriendList(int idUser)
        {
       
            var result = _userFriendRepositoryBase.GetEntityQuery().Include(x=>x.User.UserDetail).Where(x => (x.FormToUserID == idUser || x.IDUser == idUser) && x.Status == 1)
                .Select(e => new UserFirendModel()
                {
                    IDUser = e.IDUser==idUser?e.FormToUserID:e.IDUser,
                    User = e.IDUser == idUser ?null:e.User,

                });
            var res = result.ToList();

            foreach (var item in res)
            {
                if (item.User == null)
                {
                    item.User = _userRepositoryBase.GetEntityQuery().Include(x => x.UserDetail).Where(x => x.Id == item.IDUser)
                        .FirstOrDefault();
                }
                //    item.User= _userRepositoryBase.GetEntityQuery().Include(x => x.UserDetail).Where(x => x.Id == item.IDUser).FirstOrDefault();
                //item.User.UserDetail.Image= _userRepositoryBase.GetEntityQuery().Include(x => x.UserDetail).Where(x => x.Id == item.IDUser).FirstOrDefault().UserDetail.Image;

            }
            return new SuccessResult<IEnumerable<UserFirendModel>>(res);
        }
    }
}
