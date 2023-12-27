using SporcialAPI.Domain.Entities;

namespace SporcialAPI.Application.Abstractions
{
    public interface IUserActivityService
    {
        List<UserActivity> GetUserActivities();
    }
}
