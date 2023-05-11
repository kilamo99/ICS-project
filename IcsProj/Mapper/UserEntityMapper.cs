using IcsProj.DAL.Entities;

namespace IcsProj.DAL.Mapper
{
	public class UserEntityMapper : IEntityMapper<UserEntity>
	{
		public void MapToExistingEntity(UserEntity existingEntity, UserEntity newEntity)
		{
			existingEntity.FirstName = newEntity.FirstName;
			existingEntity.LastName = newEntity.LastName;
			existingEntity.Login = newEntity.Login;
			existingEntity.Gender = newEntity.Gender;
			existingEntity.ProfileImageUrl = newEntity.ProfileImageUrl;
		}
	}

}
