using System;
using System.Collections.Generic;
using System.Text;
using AppCore.DataAccess.EntityFramework.Bases;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework.Repositories.Bases {
    public class UserFriendRepositoryBase: RepositoryBase<UserFriends>
    {
        public UserFriendRepositoryBase(DbContext db) : base(db)
        {
        }
    }
}
