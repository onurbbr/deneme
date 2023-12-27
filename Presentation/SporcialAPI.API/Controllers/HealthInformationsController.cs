using Microsoft.AspNetCore.Mvc;
using SporcialAPI.Application.Abstractions;

namespace SporcialAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthInformationsController : ControllerBase
    {
        private readonly IHealthInformationService _healthInformationService;

        public HealthInformationsController(IHealthInformationService healthInformationService)
        {
            _healthInformationService = healthInformationService;
        }

        [HttpGet]
        public IActionResult GetHealthInformations()
        {
            var healthinformations = _healthInformationService.GetHealthInformations();
            return Ok(healthinformations);
        }
    }
}
