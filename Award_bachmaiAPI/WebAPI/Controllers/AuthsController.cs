using MediatR;
using Microsoft.AspNetCore.Mvc;
using Domain.models;
using Infastructure.Persitance.DbContext;
using Aplication.service.HumanData.Commands;
using Aplication.service.HumanData.Queries;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthsController : ControllerBase
{
    private readonly IMediator _mediator;

    public AuthsController(IMediator mediator)
    {
        _mediator = mediator;
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

            return Ok(result);
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
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}
