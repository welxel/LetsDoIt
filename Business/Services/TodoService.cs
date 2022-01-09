using AppCore.Business.Models.Results;
using Business.Models;
using Business.Services.Bases;
using DataAccess.EntityFramework.Repositories.Bases;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Services
{
    public class TodoService : ITodoService
    {

        private readonly TodoRepositoryBase _todoRepositoryBase;
        public TodoService(TodoRepositoryBase todoRepositoryBase)
        {
            _todoRepositoryBase = todoRepositoryBase;
        }
        public Result Add(TodoModel model)
        {
            var todo = new Todo()
            {
                IDUser = model.IDUser,
                Color = model.Color,
                Description = model.Description,
                Title = model.Title,
                Url = model.Url, 
                
            };


            _todoRepositoryBase.Add(todo);

            return new SuccessResult();

        }

        public Result Delete(int id)
        {
            _todoRepositoryBase.Delete(id);
            return new SuccessResult();
        }

        public void Dispose()
        {
            _todoRepositoryBase.Dispose();
        }

        public Result<IQueryable<TodoModel>> GetQuery()
        {
            throw new Exception();
        }

        public Result<List<TodoModel>> GetUserToDo(int id)
        {
            var result = _todoRepositoryBase.GetEntityQuery(x => x.IDUser == id).Select(e => new TodoModel()
            {
                Id = e.Id,
                Color = e.Color,
                Description = e.Description,
                IDUser = e.IDUser,
                Title = e.Title,
                Url = e.Url,
                TodoEventModel=e.TodoEvents.Select(e=>new TodoEventModel(){
                Id=e.Id
                }).ToList()
            }).ToList();

            return new SuccessResult<List<TodoModel>>(result);
        }

        public Result Update(TodoModel model)
        {
            throw new Exception();
        }
    }
}
