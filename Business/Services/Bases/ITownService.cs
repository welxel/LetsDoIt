﻿using AppCore.Business.Models.Results;
using AppCore.Business.Services.Bases;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Services.Bases
{
    public interface ITownService : IService<TownModel>
    {
        Result<IQueryable<TownModel>> GetByIDCity(int id);
    }
}
