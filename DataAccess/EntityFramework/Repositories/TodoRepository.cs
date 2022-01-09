using DataAccess.EntityFramework.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework.Repositories
{
    public class TodoRepository : TodoRepositoryBase
    {
        public TodoRepository(DbContext db) : base(db)
        {

        }
    }
}
