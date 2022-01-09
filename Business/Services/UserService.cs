using AppCore.Business.Models.Results;
using Business.Models;
using DataAccess.Repositories.Bases;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Services {
    public class UserService : IUserService {
        private readonly UserRepositoryBase _userRepository;
        public UserService(UserRepositoryBase userRepository) {
            _userRepository = userRepository;
        }

        public Result Add(UserRegisterModel model) {
            try {
                if (_userRepository.GetEntityQuery().Any(u => u.UserDetail.Email == model.Email.Trim())) {
                    return new ErrorResult("Email with same user name exists!");
                }
                var entity = new User() {
                    Active = model.Active,
                    Password = model.Password,
                    UserName = model.UserName,
                    IDCity = model.IDCity,
                    IDTown = model.IDTown,
                    Role = model.Email == "furkaanbektas@gmail.com" ? "admin" : "user",
                    ChatRoomID = Guid.NewGuid().ToString(),
                    UserDetail = new UserDetails {
                        PhoneNumber = model.PhoneNumber,
                        Jop = model.Jop,
                        Description = model.Description,
                        Adress = model.Adress,
                        Email = model.Email,
                        Image = model.Image,
                        BlogAdress = model.BlogAdress,
                        TwitterAdress = model.TwitterAdress,
                        InstagramAdress = model.InstagramAdress,
                        YoutubeAdress = model.YoutubeAdress
                    }
                };
                _userRepository.Add(entity);
                return new SuccessResult();
            } catch (Exception exc) {
                return new ErrorResult(exc.ToString());
            }
        }

        public Result Delete(int id) {
            throw new NotImplementedException();
        }

        public void Dispose() {
            _userRepository?.Dispose();
        }

        public Result<List<UserRegisterModel>> GetFilterUser(int id) {

            var result = _userRepository.GetEntityQuery().Include(x => x.UserDetail).Include(x => x.City).Include(x => x.Town).Where(x => x.Id != id).OrderBy(x => x.UserName).Select(e => new UserRegisterModel() {
                UserName = e.UserName,
                Active = e.Active,
                Id = e.Id,
                Password = e.Password,
                PhoneNumber = e.UserDetail.PhoneNumber,
                Jop = e.UserDetail.Jop,
                Description = e.UserDetail.Description,
                Adress = e.UserDetail.Adress,
                IDCity = e.IDCity,
                IDTown = e.IDTown,
                Town = e.Town.Name,
                Email = e.UserDetail.Email,
                Image = e.UserDetail.Image,
                City = e.City.Name,
                InstagramAdress = e.UserDetail.InstagramAdress,
                BlogAdress = e.UserDetail.BlogAdress,
                TwitterAdress = e.UserDetail.TwitterAdress,
                YoutubeAdress = e.UserDetail.YoutubeAdress


            });
            return new SuccessResult<List<UserRegisterModel>>(result.ToList());
        }

        public Result<IQueryable<UserRegisterModel>> GetQuery() {
            var result = _userRepository.GetEntityQuery().Include(x => x.UserDetail).Include(x => x.City).Include(x => x.Town).Select(e => new UserRegisterModel() {
                UserName = e.UserName,
                Active = e.Active,
                Id = e.Id,
                Password = e.Password,
                PhoneNumber = e.UserDetail.PhoneNumber,
                Jop = e.UserDetail.Jop,
                Description = e.UserDetail.Description,
                Adress = e.UserDetail.Adress,
                IDCity = e.IDCity,
                IDTown = e.IDTown,
                Town = e.Town.Name,
                Email = e.UserDetail.Email,
                Image = e.UserDetail.Image,
                City = e.City.Name,
                Role = e.Role
            });
            return new SuccessResult<IQueryable<UserRegisterModel>>(result);
        }

        public Result<UserRegisterModel> getUserById(int id) {
            var result = _userRepository.GetEntityQuery().Where(x => x.Id == id).Select(e => new UserRegisterModel() {
                UserName = e.UserName,
                Active = e.Active,
                Id = e.Id,
                Password = e.Password,
                Adress = e.UserDetail.Adress,
                PhoneNumber = e.UserDetail.PhoneNumber,
                Jop = e.UserDetail.Jop,
                Description = e.UserDetail.Description,
                IDCity = e.IDCity,
                IDTown = e.IDTown,
                Town = e.Town.Name,
                Email = e.UserDetail.Email,
                Image = e.UserDetail.Image,
                City = e.City.Name,


            }).FirstOrDefault();
            return new SuccessResult<UserRegisterModel>(result);

        }

        public Result Update(UserRegisterModel model) {
            try {
                var result = _userRepository.GetEntityQuery().Include(x => x.UserDetail).SingleOrDefault(x => x.Id == model.Id);
                result.UserName = model.UserName;
                result.UserDetail.Email = model.Email;
                result.UserDetail.Adress = model.Adress;
                result.IDCity = model.IDCity;
                result.IDTown = model.IDTown;
                result.UserDetail.PhoneNumber = model.PhoneNumber;
                result.UserDetail.Jop = model.Jop;
                result.UserDetail.PhoneNumber = model.PhoneNumber;
                if (model.Image != null && model.Image.Length != 0) {
                    result.UserDetail.Image = model.Image;

                }
                _userRepository.Update(result);
                return new SuccessResult();
            } catch (Exception exc) {
                return new ExceptionResult(exc);
            }


        }

        public Result UpdatePassword(UserRegisterModel userRegisterModel) {
            var user = _userRepository.GetEntityQuery().SingleOrDefault(x => x.Id == userRegisterModel.Id);
            if (user.Password == userRegisterModel.OldPassword) {
                if (userRegisterModel.NewPassword == userRegisterModel.ConfirmPassword) {
                    user.Password = userRegisterModel.NewPassword;
                    _userRepository.Update(user);
                    return new SuccessResult("Your password is updated");
                }
                return new ErrorResult("Passwords is not matched");
            }
            return new ErrorResult("Old password is not matched");
        }

    }
}
