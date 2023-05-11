using IcsProj.DAL.Factories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace IcsProj.DAL.Factories;

/// <summary>
///     EF Core CLI migration generation uses this DbContext to create model and migration
/// </summary>
public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<IcsProjDbContext>
{
    private readonly DbContextSqLiteFactory _dbContextSqLiteFactory;
    private const string ConnectionString = $"Data Source=IcsProj;Cache=Shared";

    public DesignTimeDbContextFactory()
    {
        _dbContextSqLiteFactory = new DbContextSqLiteFactory(ConnectionString);
    }

    public IcsProjDbContext CreateDbContext(string[] args) => _dbContextSqLiteFactory.CreateDbContext();
}
