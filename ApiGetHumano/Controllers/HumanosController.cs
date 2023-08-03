using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiGetHumano.Data;
using ApiGetHumano.Modelo;
using System.Collections.Generic;

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

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<Humano> { new Humano { Id = 1, Altura = 187, Edad = 31, Nombre = "Jesus1", Peso = 100, Sexo = "Masculino" },
            new Humano { Id = 1, Altura = 187, Edad = 31, Nombre = "Jesus2", Peso = 100, Sexo = "Masculino" },
            new Humano { Id = 1, Altura = 187, Edad = 31, Nombre = "Jesus3", Peso = 100, Sexo = "Masculino" },
            new Humano { Id = 1, Altura = 187, Edad = 31, Nombre = "Jesus4", Peso = 100, Sexo = "Masculino" }
            });
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
