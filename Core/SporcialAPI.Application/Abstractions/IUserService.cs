using SporcialAPI.Domain.Entities;

namespace SporcialAPI.Application.Abstractions
{
    public interface IUserService
    {
        List<User> GetUsers();
    }
}