using AppCore.DataAccess.EntityFramework.Bases;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework.Repositories.Bases
{
   public class TownRepositoryBase:RepositoryBase<Town>
    {
        public TownRepositoryBase(DbContext db):base(db)
        {

        }
    }
}
