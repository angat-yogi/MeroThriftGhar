﻿using MeroThriftGhar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeroThriftGhar.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository:IRepositoryAsync<Category>
    {
        void Update(Category category);
    }
}
