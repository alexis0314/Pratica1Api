using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pratica1Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropinaController : ControllerBase
    {
        
        [HttpGet("agregar")]
        public IActionResult Agregar(DateTime fecha, int dias)
        {
            DateTime nuevaFecha = fecha.AddDays(dias);

            return Ok(new
            {
                fechaOriginal = fecha,
                diasAgregados = dias,
                nuevaFecha
            });
        }

        // POST api/<PropinaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PropinaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PropinaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
