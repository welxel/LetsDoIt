using System;
using System.Linq;
using Business.Models;
using Business.Services;
using Business.Services.Bases;
using LetsDoItWeb.Attributes;
using LetsDoItWeb.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace LetsDoItWeb.Controllers {
    public class UserListController : Controller {
        private readonly IMemoryCache _memoryCache;
        private readonly SessionHelper _sessionHelper;
        private readonly IUserService _userService;
        private readonly IUserFriendService _userFriendService;

        public UserListController(IUserService userService, SessionHelper sessionHelper, IMemoryCache memoryCache, IUserFriendService userFriendService) {
            _memoryCache = memoryCache;
            _sessionHelper = sessionHelper;
            _userService = userService;
            _userFriendService = userFriendService;
        }

        public IActionResult Index() {
            var memoryKey = "users";

            if (_memoryCache.TryGetValue(memoryKey, out var list)) return View(list);
            var result = _userService.GetFilterUser(_sessionHelper.getCurrentUser().Id);
            _memoryCache.Set(memoryKey, result.Data, new MemoryCacheEntryOptions {
                AbsoluteExpiration = DateTime.Now.AddSeconds(3600),
                Priority = CacheItemPriority.Normal
            });
            return View(result.Data);
        }

        [HttpPost]
        public IActionResult Index(string query) {
            if (query == null) query = "";
            var result = _userService.GetFilterUser(_sessionHelper.getCurrentUser().Id);
            return View(result.Data.Where(x => x.UserName.ToLower().Contains(query.ToLower())).ToList());
        }

        //Viewden gelen datalarla arkadaş ekleme olayını gerçekleştirilecek alan.
        [HttpPost()]
        [Route("UserList/test/{idUser}")]
        public IActionResult AddFriend(int idUser) {
            var userFriend = new UserFirendModel {
                IDUser = _sessionHelper.getCurrentUser().Id,
                Status = 2, //istek beklemede olması için 2
                FormToUserID = idUser,
                CreatedDate = DateTime.Now
            };
            var result = _userFriendService.Add(userFriend);
            return View();
        }
        [HttpGet]
        [Route("UserList/GetFriendRequest")]
        public IActionResult GetFriendRequest() {
            var result = _userFriendService.GetRequestFriend(_sessionHelper.getCurrentUser().Id);
            return Ok(result.Data);
        }

        [HttpPost]
        [Route("UserList/SuccesFriend/{idUser}")]
        public IActionResult SuccesFriend(int idUser) {
            _userFriendService.FlagChange(idUser, true);
            return Ok();
        }
        [HttpPost]
        [Route("UserList/ErrorFriend/{idUser}")]
        public IActionResult ErrorFriend(int idUser) {
            _userFriendService.FlagChange(idUser, false);
            return Ok();
        }
        [HttpGet]
        [Route("UserList/FriendList")]
        public IActionResult FriendList() {
            var result = _userFriendService.UserFriendList(_sessionHelper.getCurrentUser().Id);
            return Ok(result.Data);
        }


    }
}