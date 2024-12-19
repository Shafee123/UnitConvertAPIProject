using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitConverterApi.Models;

namespace UnitConverterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionHistoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ConversionHistoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetConversionHistory()
        {
            var history = _context.ConversionHistories.OrderByDescending(c => c.ConversionDate).Take(10).ToList();
            return Ok(history);
        }

        [HttpPost]
        public IActionResult SaveConversionHistory([FromBody] ConversionHistory history)
        {
            _context.ConversionHistories.Add(history);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetConversionHistory), new { id = history.Id }, history);
        }
    }
}
