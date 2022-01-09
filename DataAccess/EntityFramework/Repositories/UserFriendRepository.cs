using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.EntityFramework.Repositories.Bases;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework.Repositories {
    public class UserFriendRepository:UserFriendRepositoryBase {

        public UserFriendRepository(DbContext db) : base(db)
        {
        }
    }
}
