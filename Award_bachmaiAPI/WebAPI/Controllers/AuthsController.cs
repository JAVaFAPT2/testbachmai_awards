using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Aplication.service.HumanData.Commands;
using Aplication.service.HumanData.Queries;
using Domain.models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IConfiguration _configuration;

        public AuthsController(IMediator mediator, IConfiguration configuration)
        {
            _mediator = mediator;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginQuery loginQuery)
        {
            if (string.IsNullOrWhiteSpace(loginQuery.Username) || string.IsNullOrWhiteSpace(loginQuery.Password))
            {
                return BadRequest("Username and password are required");
            }

            try
            {
                var result = await _mediator.Send(loginQuery);

                if (result == null)
                {
                    return Unauthorized("Invalid credentials");
                }

                var token = GenerateJwtToken(result);
                return Ok(new { token });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterCommand registerCommand)
        {
            if (string.IsNullOrWhiteSpace(registerCommand.Username) || string.IsNullOrWhiteSpace(registerCommand.Password))
            {
                return BadRequest("Username and password are required");
            }

            try
            {
                var result = await _mediator.Send(registerCommand);
                var token = GenerateJwtToken(result);
                return Ok(new { token });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        private string GenerateJwtToken(Auth user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"] ?? throw new InvalidOperationException("JWT key is missing"));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.Role, user.Role.ToString()) // Add role claim
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
