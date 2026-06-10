using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pratica1Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TextoController : ControllerBase
    {
        [HttpGet("contar")]
        public IActionResult Contar(string texto)
        {
            int palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

            int caracteres = texto.Length;

            int vocales = texto.Count(c =>
                "aeiouAEIOUáéíóúÁÉÍÓÚ".Contains(c));

            return Ok(new
            {
                palabras,
                caracteres,
                vocales
            });
        }

        [HttpGet("invertir")]
        public IActionResult Invertir(string texto)
        {
            char[] arreglo = texto.ToCharArray();

            Array.Reverse(arreglo);

            return Ok(new
            {
                original = texto,
                invertido = new string(arreglo)
            });
        }
    
// POST api/<TextoController>
[HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TextoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TextoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
