using Forum.Application.Features.Users.Commands.CreateUser;
using Forum.Application.Features.Users.Queries.GetAllUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Forum.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController: ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        public async Task<ActionResult> GetAllUsers()
        {
            var result = await _mediator.Send(new GetAllUsersQuery());
            return Ok(result);
        }

        [HttpPost("CreateUser")]
        public async Task<ActionResult> CreateUser([FromBody]CreateUserCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        
    }
}