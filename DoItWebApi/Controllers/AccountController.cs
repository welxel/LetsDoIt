using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using AppCore.Business.Models.Results;
using Business.Services.Bases.MobillAppBase;
using Business.Services.Bases;
using Business.Models.MobilAppModel;
using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Authorization;
using DoItWebApi.Attributes;

namespace DoItWebApi.Controllers {
   // [Authorize] Mobil tarafı ayağa kaldırıldığı zamanda MiddleWare aktif hale getirilecek.
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase {
        private readonly ILoginService _loginService;
        private readonly IUserService _userService;
        private readonly ICityService _cityService;
        private readonly ITownService _townService;
        public AccountController(ILoginService loginService, IUserService userService, ICityService cityService, ITownService townService) {
            _townService = townService;
            _cityService = cityService;
            _userService = userService;
            _loginService = loginService;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login(MobilLoginRequest mobilLoginRequest) {
            if (mobilLoginRequest==null)
            {
                return Ok(new ErrorResult<LoginModel>("alanlar boş bırakılamaz")); 
            }

            if (mobilLoginRequest.Email==null || mobilLoginRequest.Email =="") {
                return Ok(new ErrorResult<LoginModel>(data: null, message: "E-mail alanı boş bırakılamaz."));
            }
            if (mobilLoginRequest.Password == null || mobilLoginRequest.Password == "") {
                return Ok(new ErrorResult<LoginModel>(data: null, message: "Password alanı boş bırakılamaz."));
            }
            var result = _loginService.JWTLogin(mobilLoginRequest.Email, mobilLoginRequest.Password);
            if (result.Status == ResultStatus.Exception) {
                return BadRequest();
            }

            if (result.Status == ResultStatus.Error) {
                return Ok(new ErrorResult<LoginModel>(data: result.Data, message: result.Message));
            }

            if (result.Status == ResultStatus.Success) {

                return Ok(new SuccessResult<LoginModel>(data: result.Data, message: result.Message));
            }

            return BadRequest();
        }
        [HttpPost("register")]
        public IActionResult Register(UserRegisterModel userRegisterModel) {
            var result = _userService.Add(userRegisterModel);
            if (result.Status == ResultStatus.Error) {
                return Ok(new ErrorResult(result.Message));
            }

            if (result.Status == ResultStatus.Exception) {
                return Ok(new ErrorResult(result.Message));
            }

            if (result.Status == ResultStatus.Success) {
                return Ok(new SuccessResult("Your account added"));
            }

            return BadRequest(new ErrorResult("Somethink is wrong"));
        }
        [HttpGet("getcity")]
        public IActionResult GetCity() {
            var result = _cityService.GetQuery();
            if (result.Status == ResultStatus.Exception) {
                return BadRequest(new SuccessResult<IQueryable<CityModel>>(result.Message, result.Data));
            }

            if (result.Status == ResultStatus.Error) {
                return BadRequest(new SuccessResult<IQueryable<CityModel>>(result.Message, result.Data));
            }

            if (result.Status == ResultStatus.Success) {
                return Ok(new SuccessResult<IQueryable<CityModel>>(result.Message, result.Data));
            }
            return BadRequest(new SuccessResult<IQueryable<CityModel>>(result.Message, result.Data));
        }
        [HttpPost("gettown/{idcity}")]
        public IActionResult GetTown(int idCity) {
            var result = _townService.GetByIDCity(idCity);
            if (result.Status == ResultStatus.Exception) {
                return BadRequest(new SuccessResult<IQueryable<TownModel>>(result.Message, result.Data));
            }

            if (result.Status == ResultStatus.Error) {
                return BadRequest(new SuccessResult<IQueryable<TownModel>>(result.Message, result.Data));
            }

            if (result.Status == ResultStatus.Success) {
                return Ok(new SuccessResult<IQueryable<TownModel>>(result.Message, result.Data));
            }
            return BadRequest(new SuccessResult<IQueryable<TownModel>>(result.Message, result.Data));

        }
    }
}