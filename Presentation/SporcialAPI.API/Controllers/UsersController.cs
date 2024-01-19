﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using SporcialAPI.Application.Features.Commands.AppUser.CreateUser;

namespace SporcialAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task <IActionResult> CreateUser(CreateUserCommandRequest createUserCommandRequest)
        {
            CreateUserCommandResponse response = await _mediator.Send(createUserCommandRequest);
            return Ok(createUserCommandRequest);
        }
    }
}
