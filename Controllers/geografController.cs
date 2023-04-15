using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyTrainer.Models;

namespace MyTrainer.Controllers
{
    public class geografController : Controller
    {
        // GET: dddddController
        public ActionResult Index()
        {
            return View();
        }
        public List<Davlat> davlat = new List<Davlat>
            {
                new Davlat(1, "ИМА","Bla1", "fon4. 2.jpg"),
                new Davlat(2, "ТОҶИКИСТОН","Bla2", "fon-2.jpg"),
                new Davlat(3, "КАНАДА", "Bla3","fon4. 2.jpg"),
                new Davlat(4,  "ЕГИПЕТ", "Bla4", "fon-2.jpg"),
                new Davlat(5, "ФРАНСИЯ", "Bla5", "fon4. 2.jpg"),
                new Davlat(6,"ИТАЛИЯ", "Bla6", "fon-2.jpg"),
                new Davlat(7,"НОРВЕГИЯ", "Bla7", "fon4. 2.jpg"),
                new Davlat(8,"РУССИЯ",  "Bla8", "fon-2.jpg")
            };
        public IActionResult Davlat()
        {
            return View(davlat);
        }
        public IActionResult Poytaht()
        {
            return View(davlat);
        }
        public IActionResult Qita()
        {
            return View();
        }
        public IActionResult Uqyonus()
        {
            return View();
        }
        public IActionResult Bahr()
        {
            return View();
        }
        public IActionResult Daryo()
        {
            return View();
        }
        public IActionResult Kul()
        {
            return View();
        }
        public IActionResult Kuh()
        {
            return View();
        }
        public IActionResult Tashkilot()
        {
            return View();
        }

        // GET: dddddController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: dddddController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dddddController/Create
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

        // GET: dddddController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: dddddController/Edit/5
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

        // GET: dddddController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: dddddController/Delete/5
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
