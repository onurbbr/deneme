using SporcialAPI.Application.Abstractions;
using SporcialAPI.Domain.Entities;

namespace SporcialAPI.Persistence.Concretes
{
    public class HealthInformationService : IHealthInformationService
    {
        public List<HealthInformation> GetHealthInformations()
            => new()
            {
                new () { HealthInformationId = Guid.NewGuid(), BMI = 35, StepCount = 10000, ScreenTime = 120}
            };
    }
}