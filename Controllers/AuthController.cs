using Application.Commands.Auth;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ANUBIS_RESERVATION.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUserAccountAsync(RegisterUserAccountCommand command)
        {
            var result = await _mediator.Send(command);
            return result.IsSuccess ? Ok() : BadRequest();
        }

    }
}
