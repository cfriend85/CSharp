using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpaceCats.Models;

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
            return View();
        }

        [HttpPost("createCat")]
        public IActionResult createCat(Cat newCat)
        {
            if(ModelState.IsValid)
            {
            theCats.Add(newCat);
            return RedirectToAction("Index");
            } else {
                return View("Index");
            }
        }
    }
}
