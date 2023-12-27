using SporcialAPI.Application.Abstractions;
using SporcialAPI.Domain.Entities;

namespace SporcialAPI.Persistence.Concretes
{
    public class UserActivityService : IUserActivityService
    {
        public List<UserActivity> GetUserActivities()
            => new()
            {
                new () { ActivityId = Guid.NewGuid(), ActivityType = "Work Out", ActivityDuration = 60, ActivityDate = new DateTime(2023, 12, 27, 12, 0, 0) }
            };
    }
}
