using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpaceCats.Models;
using Microsoft.AspNetCore.Http;

namespace SpaceCats.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        static List<Cat> theCats = new List<Cat>(){};

        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("NumCats") == null)
            {
                HttpContext.Session.SetInt32("NumCats", 0);
            }
            ViewBag.CatCount = HttpContext.Session.GetInt32("NumCats");
            ViewBag.AllCats = theCats;
            return View();
        }

        [HttpPost("createCat")]
        public IActionResult createCat(Cat newCat)
        {
            if(ModelState.IsValid)
            {
            theCats.Add(newCat);
            int numCats = (int)HttpContext.Session.GetInt32("NumCats");
            HttpContext.Session.SetInt32("NumCats", numCats += 1);
            return RedirectToAction("Index");
            } else {
                ViewBag.AllCats = theCats;
                return View("Index");
            }
        }
    }
}
