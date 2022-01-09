using AppCore.Business.Models.Results;
using AppCore.Business.Services.Bases;
using Business.Models;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services.Bases
{
    public interface ITodoService : IService<TodoModel>
    {
        Result<List<TodoModel>> GetUserToDo(int id);
    }
}
