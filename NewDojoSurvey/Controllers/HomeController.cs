using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewDojoSurvey.Models;

namespace NewDojoSurvey.Controllers
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
        
        [HttpGet("form")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("Add")]
        public IActionResult Add(Survey newSurvey)
        {
            Console.WriteLine($"Name: {newSurvey.Name}, Location: {newSurvey.Location}, Fav Language: {newSurvey.Language}, Comment: {newSurvey.Comment}");
            return View("Index");
        }
    }
}
