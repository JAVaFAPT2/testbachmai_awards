using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using test1.models;
using test1.models.IRepository;

namespace test1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonsRepository _repository;

        public PersonsController(IPersonsRepository repository)
        {
            _repository = repository;
        }

        // GET: api/persons
        [HttpGet]
        public async Task<ActionResult<List<Persons>>> GetAll()
        {
            var persons = await _repository.GetAllAsync();
            return Ok(persons);
        }

        // GET: api/persons/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Persons>> GetById(string id)
        {
            var person = await _repository.GetByIdAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        // POST: api/persons
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Persons person)
        {
            await _repository.CreateAsync(person);
            return CreatedAtAction(nameof(GetById), new { id = person.Id }, person);
        }

        // PUT: api/persons/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] Persons person)
        {
            var existingPerson = await _repository.GetByIdAsync(id);
            if (existingPerson == null)
            {
                return NotFound();
            }

            await _repository.UpdateAsync(id, person);
            return NoContent();
        }

        // DELETE: api/persons/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var existingPerson = await _repository.GetByIdAsync(id);
            if (existingPerson == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}