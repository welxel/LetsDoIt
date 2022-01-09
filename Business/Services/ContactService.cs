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
    public class ContactService : IContactService
    {
        public readonly ContactRepositoryBase _contactRepositoryBase;
        public ContactService(ContactRepositoryBase contactRepositoryBase)
        {
            _contactRepositoryBase = contactRepositoryBase;
        }
        public Result Add(ContactModel model)
        {
            var entity = new Contact {
            IDUser=model.IDUser,
            Message=model.Message,
            Title=model.Title,
            };
            _contactRepositoryBase.Add(entity);
            return new SuccessResult();
        }

        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _contactRepositoryBase.Dispose();
        }

        public Result<IQueryable<ContactModel>> GetQuery()
        {
            var result = _contactRepositoryBase.GetEntityQuery().Select(e => new ContactModel()
            {

                IDUser = e.IDUser,
                User = e.User,
                Message = e.Message,
                Title = e.Title
            });
            return new SuccessResult<IQueryable<ContactModel>>(result);
        }

        public Result Update(ContactModel model)
        {
            throw new NotImplementedException();
        }
    }
}
