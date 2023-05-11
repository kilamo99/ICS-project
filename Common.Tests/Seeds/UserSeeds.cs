using IcsProj.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace IcsProj.Common.Tests.Seeds;

public static class UserSeeds
{

    public static UserEntity EmptyUserEntity = new()
    {
        Id = default,
        FirstName= default!,
        LastName= default!,
        Login = default!
    };

    public static UserEntity UserEntity1 = new()
    {
        FirstName = "fist_name_1",
        Id = Guid.Parse(input: "3cc93528-ccf9-462c-9ec7-204db00a347a"),
        LastName = "last_name_1",
        Login = "login_1",
        Gender = "male",
        ProfileImageUrl = "profile_image"
    };

    public static UserEntity UserEntity2 = new()
    {
        FirstName = "first_name_2",
        Id = Guid.Parse(input: "44c405d7-87e2-4248-b900-14c9aef9c055"),
        LastName = "last_name_2",
        Login = "login_2",
        Gender = "zena",
        ProfileImageUrl = "profile_image"
    };

    public static UserEntity UserEntity3 = new()
    {
        FirstName = "first_name_3",
        Id = Guid.Parse(input: "ed8a71b1-69e5-48b5-b5b8-5d5c5fcb75e3"),
        LastName = "last_name_3",
        Login = "login_3",
        Gender = "muz",
        ProfileImageUrl = "profile_image"
    };


	//To ensure that no tests reuse these clones for non-idempotent operations
	public static readonly UserEntity UserUpdate = UserEntity1 with { Id = Guid.Parse("143332B9-080E-4953-AEA5-BEF64679B052") };
	public static readonly UserEntity UserDelete = UserEntity1 with { Id = Guid.Parse("274D0CC9-A948-4818-AADB-A8B4C0506619") };




	public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasData(
            UserEntity1,
            UserEntity2,
            UserEntity3,
			UserUpdate,
			UserDelete);
    }
}