using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestHsAPI.Models;
using TestHsAPI.service;

namespace TestHsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HsController : ControllerBase
    {
        private readonly HSService _hsService;

        public HsController(HSService hsService)
        {
            _hsService = hsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var hsList = await _hsService.GetAllAsync();
            return Ok(hsList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var hs = await _hsService.GetByIdAsync(id);
            if (hs == null)
            {
                return NotFound();
            }
            return Ok(hs);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Hs hs)
        {
            await _hsService.CreateAsync(hs);
            return CreatedAtAction(nameof(GetById), new { id = hs.Id }, hs);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Hs updatedHs)
        {
            var hs = await _hsService.GetByIdAsync(id);
            if (hs == null)
            {
                return NotFound();
            }
            await _hsService.UpdateAsync(id, updatedHs);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var hs = await _hsService.GetByIdAsync(id);
            if (hs == null)
            {
                return NotFound();
            }
            await _hsService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("aggregated")]
        public async Task<IActionResult> GetAggregatedData()
        {
            var aggregatedData = await _hsService.GetAggregatedDataAsync();
            return Ok(aggregatedData);
        }

        [HttpGet("{id}/fullname")]
        public async Task<IActionResult> GetFullName(string id)
        {
            var fullName = await _hsService.GetFullNameAsync(id);
            if (fullName == null)
            {
                return NotFound();
            }
            return Ok(fullName);
        }

        [HttpGet("maxprice")]
        public async Task<IActionResult> GetMaxPrice()
        {
            var maxPrice = await _hsService.GetMaxPriceAsync();
            return Ok(maxPrice);
        }

        [HttpGet("minprice")]
        public async Task<IActionResult> GetMinPrice()
        {
            var minPrice = await _hsService.GetMinPriceAsync();
            return Ok(minPrice);
        }

        [HttpGet("search/daterange")]
        public async Task<IActionResult> SearchByDateRange(DateTime startDate, DateTime endDate)
        {
            var results = await _hsService.SearchByDateRangeAsync(startDate, endDate);
            return Ok(results);
        }

        [HttpGet("search/keyword")]
        public async Task<IActionResult> SearchByKeyword(string keyword)
        {
            var results = await _hsService.SearchByKeywordAsync(keyword);
            return Ok(results);
        }

        [HttpGet("search/name")]
        public async Task<IActionResult> SearchByName(string name)
        {
            var results = await _hsService.SearchByNameAsync(name);
            return Ok(results);
        }
    }
}
