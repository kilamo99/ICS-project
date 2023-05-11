using IcsProj.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcsProj.DAL.Mapper
{
    public class ActivityEntityMapper : IEntityMapper<ActivityEntity>
    {
        public void MapToExistingEntity(ActivityEntity existingEntity, ActivityEntity newEntity)
        {
            existingEntity.StartTime = newEntity.StartTime;
            existingEntity.EndTime = newEntity.EndTime;
            existingEntity.Day = newEntity.Day;
            existingEntity.NameOfActivity = newEntity.NameOfActivity;
            existingEntity.Description = newEntity.Description;
        }
    }
}
