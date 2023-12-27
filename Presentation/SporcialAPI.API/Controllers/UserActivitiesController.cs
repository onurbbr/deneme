using Microsoft.AspNetCore.Mvc;
using SporcialAPI.Application.Abstractions;

namespace SporcialAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserActivitiesController : ControllerBase
    {
        private readonly IUserActivityService _userActivityService;

        public UserActivitiesController(IUserActivityService userActivityService)
        {
            _userActivityService = userActivityService;
        }

        [HttpGet]
        public IActionResult GetUserActivities()
        {
            var useractivities = _userActivityService.GetUserActivities();
            return Ok(useractivities);
        }
    }
}
