using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiGetHumano.Data;

namespace ApiGetHumano.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumanosController : ControllerBase
    {
        private readonly ApiGetHumanoContext _context;

        public HumanosController(ApiGetHumanoContext context)
        {
            _context = context;
        }

        // GET: Humanos/GetHumanoById/5
        [HttpGet("GetHumanoById")]
        public async Task<IActionResult> GetHumanoById(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var humano = await _context.Humano
                .FirstOrDefaultAsync(m => m.Id == id);
            if (humano == null)
            {
                return NotFound();
            }

            return Ok(humano);
        }
    }
}
