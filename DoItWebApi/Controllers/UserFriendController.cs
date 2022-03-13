using AppCore.Business.Models.Results;
using Business.Models;
using Business.Models.MobilAppModel;
using Business.Services.Bases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoItWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserFriendController : ControllerBase
    {
        private readonly IUserFriendService _userFriendService;
        public UserFriendController(IUserFriendService userFriendService)
        {
            _userFriendService = userFriendService;
        }

        [HttpPost("getuserfriend")]
        public IActionResult GetUserFriend(MobilUserFriendRequest model)
        {
            var result = _userFriendService.UserFriendList(model.idUser);
            return Ok(result);
        }
    }
}
