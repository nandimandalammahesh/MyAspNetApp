using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAspNetApp.Data;     // ✅ For ApplicationDbContext
using MyAspNetApp.Models;   // ✅ For FourMData model

namespace MyAspNetApp.Controllers  // ✅ Ensure the namespace matches your project
{
    [Route("api/[controller]")]
    [ApiController]
    public class FourMController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FourMController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FourM
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _context.FourMData.ToListAsync();
            Console.WriteLine("data jehbvujhbuhvbnehivbnehivnhivnehivn",data);
            return Ok(data);
        }
    }
}
