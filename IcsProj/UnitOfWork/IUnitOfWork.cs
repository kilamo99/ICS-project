using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IcsProj.DAL.Entities;
using IcsProj.DAL.Mapper;
using IcsProj.DAL.Repositories;

namespace IcsProj.DAL.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<TEntity> GetRepository<TEntity, TEntityMapper>()
        where TEntity : class, IEntity
        where TEntityMapper : IEntityMapper<TEntity>, new();

        Task CommitAsync();
    }
    
}
