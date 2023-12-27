using SporcialAPI.Domain.Entities;

namespace SporcialAPI.Application.Abstractions
{
    public interface IHealthInformationService
    {
        List<HealthInformation> GetHealthInformations();
    }
}