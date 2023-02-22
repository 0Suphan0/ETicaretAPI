﻿using ETicaretAPI.Domain.Enitites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);

        Task<bool> AddRangeAsync(List<T> model);

        bool Remove(T model);

        bool Remove(string id);

        bool RemoveRange(List<T> models);

        Task<bool> UpdateAsync(T model);

        Task<int> SaveAsync();

    }
}
