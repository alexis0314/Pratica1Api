using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pratica1Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiempoController : ControllerBase
    {
        [HttpGet("formatear")]
        public IActionResult Formatear(int segundos)
        {
            TimeSpan tiempo = TimeSpan.FromSeconds(segundos);

            return Ok(new
            {
                horas = tiempo.Hours,
                minutos = tiempo.Minutes,
                segundos = tiempo.Seconds,
                formato = tiempo.ToString(@"hh\:mm\:ss")
            });
        }

        // POST api/<TiempoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TiempoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TiempoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
