using Business.Models;
using Business.Services.Bases;
using LetsDoItWeb.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace LetsDoItWeb.Controllers {
    public class TodoController : Controller {
        private readonly ITodoService _todoService;
        private readonly ITodoEventService _todoEventService;
        private readonly SessionHelper _sessionHelper;
        public TodoController(ITodoService todoService, ITodoEventService todoEventService, SessionHelper sessionHelper) {
            _todoEventService = todoEventService;
            _todoService = todoService;
            _sessionHelper = sessionHelper;
        }

        public IActionResult Index() {
            ViewBag.User = _sessionHelper.getCurrentUser();
            return View();
        }

        [HttpPost]
        [Route("Todo/Add")]
        public IActionResult Add([FromForm] TodoModel todoModel) {
            todoModel.IDUser = _sessionHelper.getCurrentUser().Id;
            return Ok(_todoService.Add(todoModel));
        }

        [HttpGet]
        [Route("Todo/Get/{idUser}")]
        public IActionResult GetTodo(int idUser) {
            var result = _todoService.GetUserToDo(idUser);
            return View(result.Data);
        }

        [HttpPost]
        [Route("Todo/Event/Add")]
        public IActionResult AddEvent(TodoEventModel eventModel) {
            eventModel.AllDay = true;

            _todoEventService.Add(eventModel);
            return Ok(eventModel);
        }

        [HttpGet]
        [Route("Todo/Event/Get/{idUser}")]
        public IActionResult GetTodoEvent(int idUser) {
            var result = _todoEventService.GetUserToDoEvent(idUser);
            return Ok(result.Data);
        }

        [HttpPost]
        [Route("Todo/Delete/{idTodo}")]
        public IActionResult DeleteTodo(int idTodo) {
            _todoEventService.DeleteForTodoId(idTodo);
            _todoService.Delete(idTodo);
            return Ok();
        }

        [HttpPost]
        [Route("Todo/DeleteItem/{idTodo}")]
        public IActionResult DeleteItem(int idTodo) {
            _todoEventService.DeleteItem(idTodo);
            return Ok();
        }


        [HttpGet]
        [Route("Todo/Event/{idTodoEvent}")]
        public IActionResult GetTodoEventDetail(int idTodoEvent) {
            return Ok(_todoEventService.GetTodoEventById(idTodoEvent).Data);
        }


        [HttpPost]
        [Route("Todo/Event/update")]
        public IActionResult UpdateEvent(TodoEventModel todoEventModel) {
            todoEventModel.EventDate = DateTime.Parse(todoEventModel.strDate);
            todoEventModel.EventEndDate = DateTime.Parse(todoEventModel.strEndDate);
            return Ok(_todoEventService.Update(todoEventModel));
        }

        //ajax get için orjinal data list döner
        //[HttpGet]
        //[Route("Todo/GetJson/{idUser}")]
        //public IActionResult GetTodoJson(int idUser)
        //{
        //    var result = _todoService.GetUserToDo(idUser);
        //    return Ok(result.Data);
        //}
    }
}
