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

        // GET: NumeroController/Create
        public ActionResult Create()
        {
            return View();
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
