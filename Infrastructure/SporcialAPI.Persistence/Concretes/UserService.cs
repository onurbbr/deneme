using SporcialAPI.Application.Abstractions;
using SporcialAPI.Domain.Entities;

namespace SporcialAPI.Persistence.Concretes
{
    public class UserService : IUserService
    {
        public List<User> GetUsers()
            => new()
            {
                new () { UserId = Guid.NewGuid(), UserEmail = "onurbuber@synerthink.com", UserPassword = "12345678", UserName = "Onur", UserSurname = "BUBER", UserBirthDate = new DateTime(2000, 11, 14, 6, 2, 30), UserLocation = "Karabuk", UserHeight = 192, UserWeight = 98, UserProfilePhoto = "Onur.jpg" }
            };
    }
}