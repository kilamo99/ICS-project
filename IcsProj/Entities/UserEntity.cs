using IcsProj.DAL.Entities;
using System.Security.Principal;
using System;

namespace IcsProj.DAL.Entities;

public record UserEntity : IEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Login { get; set; }
    public string? Gender { get; set; }
    public string? ProfileImageUrl { get; set; }
    public required Guid Id { get; set; }



    public ICollection<ActivityEntity>? Activities { get; set; } = new List<ActivityEntity>();
    public virtual ICollection<ProjectEntity>? Projects { get; set; } = new List<ProjectEntity>();



}
