using AppCore.Business.Models.Results;
using Business.Models;
using DataAccess.EntityFramework.Repositories;
using DataAccess.EntityFramework.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Services.Bases
{
    public class TodoEventService : ITodoEventService
    {
        public readonly TodoEventRepositoryBase _todoEventRepository;

        public TodoEventService(TodoEventRepositoryBase todoEventRepository)
        {
            _todoEventRepository = todoEventRepository;

        }
        public Result Add(TodoEventModel model)
        {
            _todoEventRepository.Add(new Entities.Entities.TodoEvent()
            {
                IDTodo = model.IDTodo,
                IDUser = model.IDUser,
                EventDate = model.EventDate,
                AllDay=model.AllDay,
                EventEndDate=model.EventEndDate

            });
            return new SuccessResult();
        }

        public Result Delete(int id)
        {
            _todoEventRepository.Delete(id);
            return new SuccessResult();
        }

        public Result DeleteForTodoId(int id)
        {

            var evenst = _todoEventRepository.GetEntityQuery().Where(x => x.Todo.Id == id).ToList();
            for (int i = 0; i < evenst.Count; i++)
            {
                _todoEventRepository.Delete(evenst[i].Id, (i + 1) == evenst.Count);

            }
            return new SuccessResult();
        }

        public void Dispose()
        {
            _todoEventRepository.Dispose();
        }

        public Result<IQueryable<TodoEventModel>> GetQuery()
        {
            throw new NotImplementedException();
        }

        public Result<TodoEventModel> GetTodoEventById(int id)
        {
            return new SuccessResult<TodoEventModel>(_todoEventRepository.GetEntityQuery().Where(x => x.Id == id).Select(e => new TodoEventModel()
            {
                Id = e.Id,
                EventDate = e.EventDate,
                IDTodo = e.IDTodo,
                Title = e.Todo.Title,
                Color = e.Todo.Color,
                Description = e.Todo.Description,
                AllDay=e.AllDay,
                Url=e.Todo.Url,
                EventEndDate = e.EventEndDate

            }).FirstOrDefault());
        }

        public Result DeleteItem(int id)
        {
            var entity = _todoEventRepository.GetEntityQuery().Where(x => x.Id == id).FirstOrDefault();
            _todoEventRepository.Delete(entity);
            return new SuccessResult();
        }

        public Result<List<TodoEventModel>> GetUserToDoEvent(int id)
        {
            var result = _todoEventRepository.GetEntityQuery(x => x.IDUser == id).Include(x => x.Todo).Select(e => new TodoEventModel()
            {
                Id = e.Id,
                EventDate = e.EventDate,
                IDTodo = e.IDTodo,
                Title = e.Todo.Title,
                Color = e.Todo.Color,
                Description = e.Todo.Description,
                AllDay=e.AllDay,
                Url=e.Todo.Url,
                EventEndDate = e.EventEndDate

            }).ToList();
            return new SuccessResult<List<TodoEventModel>>(result);

        }

        public Result Update(TodoEventModel model)
        {

            var todoEvent = _todoEventRepository.GetEntityQuery().Where(x => x.Id == model.Id).FirstOrDefault();
            if (todoEvent != null)
            {
                todoEvent.EventDate = model.EventDate;
                todoEvent.AllDay = model.AllDay;
                todoEvent.EventEndDate = model.EventEndDate;
                _todoEventRepository.Update(todoEvent);
            }


            return new SuccessResult();
        }
    }
}
