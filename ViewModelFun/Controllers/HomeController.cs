using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
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
            string paragraph = "A whole bunch of txt";
            return View("Index", paragraph);
        }

        [HttpGet("Numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[] {1,2,3,4,5};
            return View("Numbers", numbers);
        }
    }
}
