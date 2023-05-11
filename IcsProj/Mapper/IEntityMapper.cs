using IcsProj.DAL.Entities;


public interface IEntityMapper<in TEntity>
	where TEntity : IEntity
{
	void MapToExistingEntity(TEntity existingEntity, TEntity newEntity);
}

