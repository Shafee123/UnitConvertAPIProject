using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitConverterApi.Models;

namespace UnitConverterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UnitController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("categories")]
        public IActionResult GetUnitCategories()
        {
            var categories = _context.UnitCategories.ToList();
            return Ok(categories);
        }

        [HttpGet("units/{categoryId}")]
        public IActionResult GetUnitsByCategory(int categoryId)
        {
            var units = _context.Units.Where(u => u.UnitCategoryId == categoryId).ToList();
            return Ok(units);
        }

        [HttpGet("conversion/{fromUnitId}/{toUnitId}")]
        public IActionResult GetConversionRate(int fromUnitId, int toUnitId)
        {
            var conversion = _context.ConversionRates
                .FirstOrDefault(c => c.FromUnitId == fromUnitId && c.ToUnitId == toUnitId);

            if (conversion == null) return NotFound("Conversion rate not found.");

            return Ok(conversion);
        }
    }
}
