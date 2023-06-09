﻿using IcsProj.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcsProj.DAL.Repositories
{
    public interface IRepository<TEntity>
    where TEntity : class, IEntity
    {
        IQueryable<TEntity> Get();
        void Delete(Guid entityId);
        ValueTask<bool> ExistsAsync(TEntity entity);
        Task<TEntity> InsertAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
    }

}
