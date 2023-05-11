using IcsProj.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace IcsProj.Common.Tests.Seeds;

public static class ActivitySeeds
{


    ////To ensure that no tests reuse these clones for non-idempotent operations
    public static ActivityEntity EmptyActivityEntity = new()
    {
        Id = default,
        NameOfActivity = default!,
        Day = DayOfWeek.Monday,
        StartTime = default,
        EndTime = default
    };

    public static ActivityEntity ActivityEntity1 = new()
    {
        Id = Guid.Parse(input: "e4b46f5c-2b8c-4b24-bd56-6f90ba30a71d"),
        NameOfActivity = "name_of_activity_1",
        Day = DayOfWeek.Monday,
        StartTime = new DateTime(2023,1,1,12,0,0),
        EndTime = new DateTime(2023, 1, 1, 13, 30, 0)

    };

    public static ActivityEntity ActivityEntity2 = new()
    {
        Id = Guid.Parse(input: "5a5a91ce-5f47-4a34-a1d7-5a07b5ec5b1c"),
        NameOfActivity = "name_of_activity_1",
        Day = DayOfWeek.Tuesday,
        StartTime = new DateTime(2023, 1, 1, 12, 0, 0),
        EndTime = new DateTime(2023, 1, 1, 14, 30, 0)

    };

    public static ActivityEntity ActivityEntity3 = new()
    {
        Id = Guid.Parse(input: "a5a5a39b-24f8-4f25-ae7f-6e4b6c8ad53c"),
        NameOfActivity = "name_of_activity_2",
        Day = DayOfWeek.Monday,
        StartTime = new DateTime(2023, 1, 1, 12, 0, 0),
        EndTime = new DateTime(2023, 1, 1, 13, 30, 0)

    };

	public static readonly ActivityEntity ActivityUpdate = ActivityEntity1 with { Id = Guid.Parse("143332B9-080E-4953-AEA5-BEF64679A053") };
	public static readonly ActivityEntity ActivityDelete = ActivityEntity1 with { Id = Guid.Parse("274D0CC9-A948-4818-AADB-A8B4C0507610") };




	public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActivityEntity>().HasData(
            ActivityUpdate,
            ActivityDelete,
            ActivityEntity1,
            ActivityEntity2,
            ActivityEntity3);
    }
}