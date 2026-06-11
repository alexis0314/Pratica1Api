using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pratica1Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropinaController : ControllerBase
    {
        [HttpGet("calcular")]
        public IActionResult Calcular(decimal monto, decimal porcentaje)
        {
            decimal propina = monto * porcentaje / 100;

            decimal total = monto + propina;

            return Ok(new
            {
                monto,
                propina,
                total
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
