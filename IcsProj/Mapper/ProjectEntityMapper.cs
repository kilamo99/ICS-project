using IcsProj.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcsProj.DAL.Mapper
{
    public class ProjectEntityMapper : IEntityMapper<ProjectEntity>
    {
        public void MapToExistingEntity(ProjectEntity existingEntity, ProjectEntity newEntity)
        {
            existingEntity.ProjectName = newEntity.ProjectName;
            existingEntity.NumberOfClaims = newEntity.NumberOfClaims;
           
        }
    }
}
