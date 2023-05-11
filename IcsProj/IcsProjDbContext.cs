using IcsProj.DAL.Entities;
//using CookBook.DAL.Seeds;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;

namespace IcsProj.DAL;

public class IcsProjDbContext : DbContext
{
    private readonly bool _seedDemoData;

    public IcsProjDbContext(DbContextOptions contextOptions, bool seedDemoData = false)
        : base(contextOptions) =>
    _seedDemoData = seedDemoData;

    public DbSet<ActivityEntity> Activities => Set<ActivityEntity>();
    public DbSet<UserEntity> Users => Set<UserEntity>();
    public DbSet<ProjectEntity> Projects => Set<ProjectEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<UserEntity>()
            .HasMany(u => u.Projects)
            .WithMany(a => a.Users)
            .UsingEntity(j => j.ToTable("UserProjects"));

        modelBuilder.Entity<UserEntity>()
                    .HasMany(u => u.Activities)
                    .WithMany(a => a.Users)
                    .UsingEntity(j => j.ToTable("UserActivities"));

        modelBuilder.Entity<ActivityEntity>()
                    .HasOne(u => u.Project)
                    .WithMany(a => a.Activities);
    }
}
