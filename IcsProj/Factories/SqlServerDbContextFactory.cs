using Microsoft.EntityFrameworkCore;

namespace IcsProj.DAL.Factories;

public class SqlServerDbContextFactory : IDbContextFactory<IcsProjDbContext>
{
    private readonly bool _seedDemoData;
    private readonly DbContextOptionsBuilder<IcsProjDbContext> _contextOptionsBuilder = new();

    public SqlServerDbContextFactory(string connectionString, bool seedDemoData = false)
    {
        _seedDemoData = seedDemoData;

        _contextOptionsBuilder.UseSqlServer(connectionString);

        ////Enable in case you want to see tests details, enabled may cause some inconsistencies in tests
        //_contextOptionsBuilder.LogTo(System.Console.WriteLine);
        //_contextOptionsBuilder.EnableSensitiveDataLogging();
    }

    public IcsProjDbContext CreateDbContext() => new(_contextOptionsBuilder.Options, _seedDemoData);
}