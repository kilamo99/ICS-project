using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcsProj.DAL.UnitOfWork
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private readonly IDbContextFactory<IcsProjDbContext> _dbContextFactory;

        public UnitOfWorkFactory(IDbContextFactory<IcsProjDbContext> dbContextFactory) =>
            _dbContextFactory = dbContextFactory;

        public IUnitOfWork Create() => new UnitOfWork(_dbContextFactory.CreateDbContext());
    }
}
