using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pratica1Api.Controllers
{
    public class NumeroController : Controller
    {
        // GET: NumeroController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NumeroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpGet("analizar")]
        // GET: NumeroController/Create
        public ActionResult Analizar (int n)
        {
            bool esPar = n % 2 == 0;
            bool esPrimo = EsPrimo(n);

            string signo;

            if (n > 0)
                signo = "Positivo";
            else if (n < 0)
                signo = "Negativo";
            else
                signo = "Cero";

            return Ok(new
            {
                Numero = n,
                EsPar = esPar,
                EsPrimo = esPrimo,
                Tipo = signo
            });
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }

        // POST: NumeroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NumeroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NumeroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NumeroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NumeroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
