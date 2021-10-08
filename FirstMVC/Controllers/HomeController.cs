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
            List<string> petNames = new List<string>(){
                "Buddy",
                "Fluffy",
                "Cat",
                "Spot"
            };
            return View(petNames); //pass the List into the view
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
            return View("Result", newPet);
            } else {
                Console.WriteLine("Something went wrong with your model");
                return View("Form");
            }
        }
    }
}
