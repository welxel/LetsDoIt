using AppCore.Business.Models.Results;
using Business.Models;
using Business.Services;
using Business.Services.Bases;
using LetsDoItWeb.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsDoItWeb.Controllers {
    public class ContactController : Controller {
        private readonly SessionHelper _sessionHelper;
        private readonly IContactService _contactService;
        public ContactController(SessionHelper sessionHelper, IContactService contactService) {
            _sessionHelper = sessionHelper;
            _contactService = contactService;
        }
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactModel model) {
            model.IDUser = _sessionHelper.getCurrentUser().Id;
            var result = _contactService.Add(model);
            if (result.Status == ResultStatus.Success) {
                ViewBag.isSuccess = true;
                return View();
            } else {
                ViewBag.isSuccess = false;
                return View();
            }

        }
    }
}
