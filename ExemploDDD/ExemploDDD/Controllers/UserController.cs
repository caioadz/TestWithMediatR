using System.Threading.Tasks;
using ExemploDDD.Application.Commands;
using ExemploDDD.Domain.Entity;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ExemploDDD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<User> Post([FromBody] CreateUserCommand createUser)
        {
            return await _mediator.Send(createUser);
        }
    }
}
