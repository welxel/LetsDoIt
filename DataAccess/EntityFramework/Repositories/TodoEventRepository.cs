using DataAccess.EntityFramework.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework.Repositories
{
    public class TodoEventRepository : TodoEventRepositoryBase
    {
        public TodoEventRepository(DbContext db) : base(db)
        {

        }
    }
}
