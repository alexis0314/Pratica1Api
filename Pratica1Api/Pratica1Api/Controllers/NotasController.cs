using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pratica1Api.Models;

namespace Pratica1Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotasController : ControllerBase
    {
        [HttpPost("estadisticas")]
        public IActionResult Estadisticas([FromBody] NotasRequest request)
        {
            return Ok(new
            {
                promedio = request.Notas.Average(),
                mayor = request.Notas.Max(),
                menor = request.Notas.Min(),
                aprobados = request.Notas.Count(x => x >= 70),
                reprobados = request.Notas.Count(x => x < 70)
            });
        }
    }
}
