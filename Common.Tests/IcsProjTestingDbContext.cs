using IcsProj.Common.Tests.Seeds;
using IcsProj.DAL;
using Microsoft.EntityFrameworkCore;

namespace IcsProj.Common.Tests;

public class IcsProjTestingDbContext : IcsProjDbContext
{
    private readonly bool _seedTestingData;

    public IcsProjTestingDbContext(DbContextOptions contextOptions, bool seedTestingData = false)
        : base(contextOptions, seedDemoData: false)
    {
        _seedTestingData = seedTestingData;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        if (_seedTestingData)
        {
            UserSeeds.Seed(modelBuilder);
            ProjectSeeds.Seed(modelBuilder);
            ActivitySeeds.Seed(modelBuilder);
        }
    }
}