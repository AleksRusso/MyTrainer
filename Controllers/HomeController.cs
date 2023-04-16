using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyTrainer.Models;
using System.Data;
using System.Diagnostics;

namespace MyTrainer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Courses()
        {
            return View();
        }
        List<Kitob> knigi = new List<Kitob>
            {
                new Kitob(1, "Якум", "маълумот1", "fon4. 2.jpg"),
                new Kitob(2, "Дуюм", "маълумот2", "fon-2.jpg"),
                new Kitob(3, "Сеюм", "маълумот3", "fon-2.jpg"),
                new Kitob(4, "Чорум", "маълумот4", "fon4. 2.jpg"),
                new Kitob(5, "Панҷум", "маълумот5", "fon-2.jpg"),
                new Kitob(3, "Шашум", "маълумот6", "fon-2.jpg"),
            };

        public IActionResult Events()
        {
            return View(knigi);
        }
        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult Block_home()
        {
            return View();
        }
        public IActionResult Block_single()
        {
            return View();
        }

       
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Course_details()
        {
            return View();
        }
        public IActionResult Events_details()
        {
            return View();
        }
        public IActionResult Elements()
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
        

        public IActionResult Bozi()
        {
            return View();
        }
       

        //[HttpGet]  не нужен
        public IActionResult State(int id)
        {
            foreach (var d in davlat)
            {
                if (d.id == id) { return View(d); }

            }
            return View(null);

        }


        [Authorize(Roles = "admin")]
        public IActionResult Dohilkuni()
        {
            return View();
        }


        //[HttpGet]
        //public IActionResult Dohilkuni()
        //{
        //    return View();
        //}
        //////[HttpPost]
        //public IActionResult Dohilkuni()
        //{
        //    //if (email == "aleksrusso.wizard@gmail.com" && password == "123456")
        //    //{
        //    //    string email, string password
        //        ViewBag.Davlat = "НОМ,ПОЙТАХТ,МАСОХАТ,АХОЛӢ,ЗАБОН,АСЪОР";
        //        ViewBag.Poytaht = "НОМ, ПОЙТАХТИ ДАВЛАТИ, МАСОҲАТ, АҲОЛӢ, ЗАБОН, АСЪОР";
        //        ViewBag.Tashkilot = "НОМ, Дар бар мегирад, Қабул шуд, ШТАБ, ЗАБОН";
        //        ViewBag.Bahr = "НОМ, Ҷойгиршавӣ, МАСОҲАТ, Ҷуқурӣ";
        //        ViewBag.Daryo = "НОМ,Ҷойгиршавӣ , Дарозӣ , Баландӣ";
        //        ViewBag.Kul = "НОМ, МАСОҲАТ, Дарозӣ, Ҷуқурӣ, Намакӣ,Ҷойгиршавӣ ";
        //        ViewBag.Kuh = "НОМ,Ҷойгиршавӣ, Баландӣ";

        //        return View();
        //    ////}
        //    ////else { return View(null); }
        //}

        [Authorize(Roles = "admin")]

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}