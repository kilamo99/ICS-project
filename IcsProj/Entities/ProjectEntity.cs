

using System;



namespace IcsProj.DAL.Entities;

public record ProjectEntity : IEntity
{

    public required String ProjectName { get; set; }
    public int NumberOfClaims { get; set; }
    public required Guid Id { get; set; }

    public virtual ICollection<UserEntity>? Users { get; set; } = new List<UserEntity>();

    public virtual ICollection<ActivityEntity>? Activities { get; set; } = new List<ActivityEntity>();

}
