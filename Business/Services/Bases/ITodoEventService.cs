using AppCore.Business.Models.Results;
using AppCore.Business.Services.Bases;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services.Bases
{
    public interface ITodoEventService : IService<TodoEventModel>
    {
        Result<List<TodoEventModel>> GetUserToDoEvent(int id);
        Result DeleteForTodoId(int id);
        Result<TodoEventModel> GetTodoEventById(int id);
        Result DeleteItem(int id);

    }
}
