using IcsProj.DAL.Entities;
using IcsProj.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcsProj.DAL.UnitOfWork
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        public UnitOfWork(DbContext dbContext) =>
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

        public IRepository<TEntity> GetRepository<TEntity, TEntityMapper>()
            where TEntity : class, IEntity
            where TEntityMapper : IEntityMapper<TEntity>, new()
            => new Repository<TEntity>(_dbContext, new TEntityMapper());

        public async Task CommitAsync() => await _dbContext.SaveChangesAsync();

        public async ValueTask DisposeAsync() => await _dbContext.DisposeAsync();
    }
}
