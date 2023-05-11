using IcsProj.DAL;
using IcsProj.Common.Tests;
using Microsoft.EntityFrameworkCore;

namespace IcsProj.Common.Tests.Factories;

public class DbContextSqLiteTestingFactory : IDbContextFactory<IcsProjDbContext>
{
    private readonly string _databaseName;
    private readonly bool _seedTestingData;

    public DbContextSqLiteTestingFactory(string databaseName, bool seedTestingData = false)
    {
        _databaseName = databaseName;
        _seedTestingData = seedTestingData;
    }
    public IcsProjDbContext CreateDbContext()
    {
        DbContextOptionsBuilder<IcsProjDbContext> builder = new();
        builder.UseSqlite($"Data Source={_databaseName};Cache=Shared");

         //contextOptionsBuilder.LogTo(System.Console.WriteLine); //Enable in case you want to see tests details, enabled may cause some inconsistencies in tests
         //builder.EnableSensitiveDataLogging();

        return new IcsProjTestingDbContext(builder.Options, _seedTestingData);
    }
}