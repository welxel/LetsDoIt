using Business.Services.Bases;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsDoItWeb.Controllers {
    public class LocationController : Controller {

        private readonly ITownService _townService;
        public LocationController(ITownService townService) {
            _townService = townService;
        }
        public IActionResult Index() {
            return View();
        }


        [Route("town/get/{idcity}")]
        public IActionResult GetCities(int idcity) {
            var result = _townService.GetByIDCity(idcity).Data;
            return Ok(result);
        }
    }
}
