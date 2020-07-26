using BeeApp.Repository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BeeApp.Controllers
{
    public class HomeController : Controller
    {
        
        static Drone drone;
        static Queen queen;
        static Worker worker;

        public HomeController()
        {
            if (drone == null)
                drone = new Drone();
            if (queen == null)
                queen = new Queen();
            if (worker == null)
                worker = new Worker();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Damage()
        {
            Random random = new Random();
            int damageValue = random.Next(0, 80);
            drone.Damage(damageValue);
            ViewBag.Drone = drone.DisplayValue();



            damageValue = random.Next(0, 80);
            queen.Damage(damageValue);
            ViewBag.Queen = queen.DisplayValue();



            damageValue = random.Next(0, 80);
            worker.Damage(damageValue);
            ViewBag.Worker = worker.DisplayValue();


            return View("Index");
        }
    }
}
