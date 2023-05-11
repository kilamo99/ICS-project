using IcsProj.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace IcsProj.Common.Tests.Seeds;

public static class ProjectSeeds
{
    public static ProjectEntity ProjectEntity_Empty = new()
    {
        Id = default,
        ProjectName = default!,
        NumberOfClaims = default,
    };

    public static ProjectEntity ProjectEntity1 = new()
    {
        Id = Guid.Parse(input: "2d4a04a1-f7da-4fc2-af0a-23c3e524bb01"),
        ProjectName = "project_name_1",
        NumberOfClaims = 1

    };

    public static ProjectEntity ProjectEntity2 = new()
    {
        Id = Guid.Parse(input: "b9f19077-92c8-47f1-a6c9-46033cb36421"),
        ProjectName = "project_name_1",
        NumberOfClaims = 3

    };
    public static ProjectEntity ProjectEntity3 = new()
    {
        Id = Guid.Parse(input: "7492f63c-9b9f-4371-87f8-f20c40b6cb2b"),
        ProjectName = "project_name_2",
        NumberOfClaims = 1

    };




    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProjectEntity>().HasData(
            ProjectEntity1,
            ProjectEntity2,
            ProjectEntity3);
    }
}