using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestHsAPI.Models;
using TestHsAPI.service;

namespace TestHsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HSController : ControllerBase
    {
        private readonly HSService _hsService;

        public HSController(HSService hsService)
        {
            _hsService = hsService;
        }

        // GET: api/<HSController>
        [HttpGet]
        public async Task<ActionResult<List<Hs>>> Get()
        {
            var hsList = await _hsService.GetAllAsync();
            return Ok(hsList);
        }

        // GET api/<HSController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hs>> Get(string id)
        {
            var hs = await _hsService.GetByIdAsync(id);
            if (hs == null)
            {
                return NotFound();
            }
            return Ok(hs);
        }

        // POST api/<HSController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Hs hs)
        {
            await _hsService.CreateAsync(hs);
            return CreatedAtAction(nameof(Get), new { id = hs.Id }, hs);
        }

        // PUT api/<HSController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, [FromBody] Hs updatedHs)
        {
            var hs = await _hsService.GetByIdAsync(id);
            if (hs == null)
            {
                return NotFound();
            }
            await _hsService.UpdateAsync(id, updatedHs);
            return NoContent();
        }

        // DELETE api/<HSController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var hs = await _hsService.GetByIdAsync(id);
            if (hs == null)
            {
                return NotFound();
            }
            await _hsService.DeleteAsync(id);
            return NoContent();
        }

        // GET api/<HSController>/aggregated
        [HttpGet("aggregated")]
        public async Task<ActionResult<List<BsonDocument>>> GetAggregatedData()
        {
            var aggregatedData = await _hsService.GetAggregatedDataAsync();
            return Ok(aggregatedData);
        }
    }
}
