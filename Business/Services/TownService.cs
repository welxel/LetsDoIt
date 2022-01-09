using AppCore.Business.Models.Results;
using Business.Models;
using Business.Services.Bases;
using DataAccess.EntityFramework.Repositories.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Services
{
    public class TownService : ITownService
    {
        private readonly TownRepositoryBase _townRepositoryBase;
        public TownService(TownRepositoryBase townRepositoryBase)
        {
            _townRepositoryBase = townRepositoryBase;
        }
        public Result Add(TownModel model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _townRepositoryBase.Dispose();
        }

        public Result<IQueryable<TownModel>> GetByIDCity(int id)
        {
            var result = _townRepositoryBase.GetEntityQuery().Where(x => x.City.Id == id).Select(e => new TownModel()
            {
                Id = e.Id,
                Name = e.Name
            });
            return new SuccessResult<IQueryable<TownModel>>(result);
        }

        public Result<IQueryable<TownModel>> GetQuery()
        {

            var result = _townRepositoryBase.GetEntityQuery().Select(e => new TownModel()
            {
                Id = e.Id,
                Name = e.Name
            });
            return new SuccessResult<IQueryable<TownModel>>(result);
        }

        public Result Update(TownModel model)
        {
            throw new NotImplementedException();
        }
    }
}
