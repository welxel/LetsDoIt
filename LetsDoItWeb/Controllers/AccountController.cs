using AppCore.Business.Models.Results;
using Business.Models;
using Business.Services.Bases;
using Business.ViewModel;
using LetsDoItWeb.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LetsDoItWeb.Attributes;
using Business.Services;

namespace LetsDoItWeb.Controllers {
    public class AccountController : Controller {
        private readonly IUserService _userService;
        private readonly SessionHelper _sessionHelper;
        private readonly FileHelper _fileHelper;
        private readonly ITownService _townService;
        private readonly ICityService _cityService;

        public AccountController(IUserService userService, SessionHelper sessionHelper, FileHelper fileHelper, ITownService townService, ICityService cityService) {
            _userService = userService;
            _sessionHelper = sessionHelper;
            _fileHelper = fileHelper;
            _cityService = cityService;
            _townService = townService;
        }

        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserRegisterModel userRegister) {
            var result = _userService.GetQuery();
            if (result.Status == ResultStatus.Success) {
                var account = result.Data.SingleOrDefault(u => u.Email == userRegister.Email && u.Password == userRegister.Password);

                if (account == null) {
                    ViewBag.message = "No matching records found";
                    return View();
                }
                if (!account.Active) {
                    ViewBag.message = "Your account is block";
                    return View();
                }
                _sessionHelper.setSession(account);
               var loginedUser = _sessionHelper.getCurrentUser();
                ViewBag.user = loginedUser;
                return RedirectToAction("Index", "Todo");
            }
            return View();
        }

        public IActionResult Register() {
            ViewBag.Cities = _cityService.GetQuery().Data;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([FromForm] UserRegisterViewModel userRegisterViewModel) {
            ViewBag.Cities = _cityService.GetQuery().Data;
            if (userRegisterViewModel.userRegisterModel.Password != userRegisterViewModel.userRegisterModel.ConfirmPassword) {
                ViewBag.message = "Password does not match";
                return View();
            }
            userRegisterViewModel.userRegisterModel.Image = await _fileHelper.SaveFile(userRegisterViewModel.formFile);
            var result = _userService.Add(userRegisterViewModel.userRegisterModel);
            if (result.Status == ResultStatus.Success) {
                return RedirectToAction("Login");
            }
            if (result.Status == ResultStatus.Error) {
                ViewBag.message = result.Message;
                return View();
            }
            return View();
        }


    }
}
