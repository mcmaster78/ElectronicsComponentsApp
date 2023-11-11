﻿using ElectronicsComponentsApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsComponentsApp.Repositories
{
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
    where T : class, IEntity
    {
    }
}
