using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;

using Aplication.service.HumanData.Commands;
using Application.Service.HumanData.Queries;
using Application.Features.Humans.Queries;

namespace Application.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PeopleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // POST: api/people
        [HttpPost]
        public async Task<IActionResult> CreatePerson([FromBody] CreatePersonCommand createPersonCommand)
        {
            var result = await _mediator.Send(createPersonCommand);
            return CreatedAtAction(nameof(GetPersonById), new { id = result.Id }, result);
        }

        // PUT: api/people/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePerson(Guid id, [FromBody] UpdatePersonCommand updatePersonCommand)
        {
            if (id != updatePersonCommand.Id)
            {
                return BadRequest("ID mismatch");
            }

            var updatedPerson = await _mediator.Send(updatePersonCommand);
            if (updatedPerson == null)
            {
                return NotFound();
            }

            return NoContent(); // Optionally return Ok(updatedPerson) if you want the updated object
        }

        // GET: api/people/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<GetPeoplesByIdQuery>> GetPersonById(Guid id)
        {
            var query = new GetPeoplesByIdQuery(id);
            var person = await _mediator.Send(query);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        // GET: api/people/email/{email}
        [HttpGet("email/{email}")]
        public async Task<ActionResult<GetPeoplesByEmailQuery>> GetHumanByEmail(string email)
        {
            var query = new GetPeoplesByEmailQuery(email);
            var person = await _mediator.Send(query);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        // GET: api/people
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetAllPeoplesQueries>>> GetAllHumans()
        {
            var query = new GetAllPeoplesQueries();
            var persons = await _mediator.Send(query);
            return Ok(persons);
        }
    }
}