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
    public class CityService : ICityService
    {
        private readonly CityRepositoryBase _cityRepositoryBase;
        public CityService(CityRepositoryBase cityRepositoryBase)
        {
            _cityRepositoryBase = cityRepositoryBase;
        }
        public Result Add(CityModel model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _cityRepositoryBase.Dispose();
        }

        public Result<IQueryable<CityModel>> GetQuery()
        {
            var result = _cityRepositoryBase.GetEntityQuery().Select(e => new CityModel()
            {
                Id = e.Id,
                Name = e.Name
            });
            return new SuccessResult<IQueryable<CityModel>>(result);
        }

        public Result Update(CityModel model)
        {
            throw new NotImplementedException();
        }
    }
}
