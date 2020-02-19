using System.Threading.Tasks;
using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _service;

        public AccountController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]AdminDto admin)
        {
            var token = await _service.LoginAsync(admin);
            if (token != null)
            {
                return Ok(new { Token = token });
            }
            return BadRequest(admin);
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]AdminDto admin)
        {
            var isRegisterSuccessful = await _service.RegisterAsync(admin);

            if (isRegisterSuccessful)
            {
                return CreatedAtAction(nameof(Register), admin);
            }

            return BadRequest(admin);
        }

        // /api/account/confirmemail?userid&token
        [HttpGet("confirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(token))
                return NotFound();

            var isConfirmed = await _service.ConfirmEmailAsync(userId, token);

            if (isConfirmed)
            {
                return Ok(userId);
            }

            return BadRequest(new {userId, token});
        }
    }
}
