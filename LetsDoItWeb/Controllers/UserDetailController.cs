
using LetsDoItWeb.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using Business.ViewModel;
using Business.Services;
using Business.Services.Bases;
using AppCore.Business.Models.Results;

namespace LetsDoItWeb.Controllers {
    public class UserDetailController : Controller {
        private readonly SessionHelper _sessionHelper;
        private readonly IUserService _userService;
        private readonly FileHelper _fileHelper;
        private readonly ICityService _cityService;
        public UserDetailController(SessionHelper sessionHelper, IUserService userService, FileHelper fileHelper, ICityService cityService) {
            _cityService = cityService;
            _fileHelper = fileHelper;
            _userService = userService;
            _sessionHelper = sessionHelper;
        }
        [HttpGet]
        public IActionResult List() {
            UserRegisterViewModel userRegisterView = new UserRegisterViewModel();
            ViewBag.Cities = _cityService.GetQuery().Data;
            var abc = _sessionHelper.getCurrentUser();
            userRegisterView.userRegisterModel = abc;
            return View(userRegisterView);
        }


        [HttpPost]
        public async Task<IActionResult> UpdateUserDetail(UserRegisterViewModel userRegisterViewModel) {
            ViewBag.Cities = _cityService.GetQuery().Data;
            if (userRegisterViewModel.userRegisterModel.Email == null && userRegisterViewModel.userRegisterModel.UserName == null
                && userRegisterViewModel.userRegisterModel.Description == null && userRegisterViewModel.userRegisterModel.Jop == null && userRegisterViewModel.userRegisterModel.PhoneNumber == null) {
                TempData["errormessage"] = "you must fill in the missing fields.";
                return RedirectToAction("List");
            }

            if (userRegisterViewModel.formFile != null) {
                userRegisterViewModel.userRegisterModel.Image = await _fileHelper.SaveFile(userRegisterViewModel.formFile);
            }


            var result = _userService.Update(userRegisterViewModel.userRegisterModel);
            if (result.Status == ResultStatus.Success) {
                TempData["succesmessage"] = "Updated is succesfull";
                ViewBag.SuccesMessage = "Your description is updated";
                var user = _userService.getUserById(userRegisterViewModel.userRegisterModel.Id);
                _sessionHelper.setSession(user.Data);
                return RedirectToAction("List");
            }
            return View();
        }

        public IActionResult UpdatePassword(UserRegisterViewModel userRegisterViewModel) {
            var session_user = _sessionHelper.getCurrentUser();
            var result = _userService.UpdatePassword((userRegisterViewModel.userRegisterModel));
            if (result.Status == ResultStatus.Success) {
                TempData["SuccesPasswordMessage"] = result.Message;
                var old_session = _sessionHelper.getCurrentUser();
                old_session.Password = (userRegisterViewModel.userRegisterModel.NewPassword);
                _sessionHelper.setSession(old_session);
                return RedirectToAction("List");
            }
            TempData["ErrorPasswordMessage"] = result.Message;
            return RedirectToAction("List");
        }
    }
}
