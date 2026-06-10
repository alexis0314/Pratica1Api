using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pratica1Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImcController : ControllerBase
    {
        [HttpGet("calcular")]
        public IActionResult Calcular(double peso, double altura)
        {
            double imc = peso / (altura * altura);

            string categoria;

            if (imc < 18.5)
                categoria = "Bajo peso";
            else if (imc < 25)
                categoria = "Normal";
            else if (imc < 30)
                categoria = "Sobrepeso";
            else
                categoria = "Obesidad";

            return Ok(new
            {
                imc,
                categoria
            });
        }

        // POST api/<ImcController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ImcController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ImcController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
