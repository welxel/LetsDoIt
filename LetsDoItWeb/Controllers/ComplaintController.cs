using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Models;
using Business.Services.Bases;
using LetsDoItWeb.Attributes;
using LetsDoItWeb.Helpers;
using PagedList.Core;

namespace LetsDoItWeb.Controllers {
    public class ComplaintController : Controller {
        private readonly IContactService _contactService;
        public ComplaintController(IContactService contactService) {
            _contactService = contactService;
        }

        [RoleControl()]
        public IActionResult Index(int page = 1, int pageSize = 10) {
            var result = _contactService.GetQuery().Data;
            PagedList<ContactModel> model = new PagedList<ContactModel>(result, page, pageSize);
            return View(model);
        }
    }
}
    