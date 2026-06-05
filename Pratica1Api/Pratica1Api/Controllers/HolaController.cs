using Microsoft.AspNetCore.Mvc;

namespace Pratica1Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolaController : ControllerBase
    {
        [HttpGet("saludo")]
        public IActionResult Saludo(string nombre)
        {
            return Ok(new
            {
                mensaje = $"Bienvenido {nombre}"
            });
        }
    }
}