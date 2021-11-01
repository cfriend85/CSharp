using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Chef> AllChefs = _context.Chefs.ToList();
            return View(AllChefs);
        }
        
        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> AllDishes = _context.Dishes.Include(c => c.Chef).ToList();
            return View(AllDishes);
        }

        [HttpGet("new")]
        public IActionResult NewChef()
        {
            ViewBag.Today = DateTime.Today;
            return View();
        }

        [HttpPost("addChef")]
        public IActionResult AddChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newChef);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("AddChef");
            }
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            ViewBag.Chefs = _context.Chefs.ToList();
            return View();
        }

        [HttpPost("addDish")]
        public IActionResult AddDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Dishes");
            } else {
                return View("NewDish");
            }
        }
    }
}
