using System;



namespace IcsProj.DAL.Entities;

public record ActivityEntity : IEntity
{
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public DayOfWeek? Day { get; set; }

    public required String NameOfActivity { get; set; }
    public String? Description { get; set; }
    public required Guid Id { get; set; }
    public ICollection<UserEntity>? Users { get; set; } = new List<UserEntity>();
    
    public ProjectEntity? Project { get; set; }


}
