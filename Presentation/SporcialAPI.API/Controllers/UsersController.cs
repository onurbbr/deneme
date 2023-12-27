using Microsoft.AspNetCore.Mvc;
using SporcialAPI.Application.Abstractions;

namespace SporcialAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            var users = _userService.GetUsers();
            return Ok(users);
        }
    }
}
