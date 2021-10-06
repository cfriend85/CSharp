using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstMVC.Models;

namespace FirstMVC.Controllers
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
        
        [HttpGet("Form")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("Add")]
        public IActionResult Add(Pet newPet) //this uses the Pet object from the form as a parameter
        {
            if(ModelState.IsValid)
            {
            Console.WriteLine("You added a pet *********************");
            Console.WriteLine($"Name: {newPet.Name}, Species: {newPet.Species}, Age: {newPet.Age}");
            // ViewBag.Pet = newPet; this passes the whole Pet object into the ViewBag and on the View you'd need something like @ViewBag.Pet.Name and possibly some logic if it's empty or not
            ViewBag.Name = newPet.Name;
            ViewBag.Species = newPet.Species;
            ViewBag.Age = newPet.Age;
            return View("Form");
            } else {
                Console.WriteLine("Something went wrong with your model");
                return View("Form");
            }

        }
    }
}
