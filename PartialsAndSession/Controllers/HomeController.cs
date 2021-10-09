using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartialsAndSession.Models;
using Microsoft.AspNetCore.Http;

namespace PartialsAndSession.Controllers
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
            //Stage1: Need to SET session
            HttpContext.Session.SetString("LoggedInUser", "Charles");
            HttpContext.Session.SetInt32("LuckyNumber", 11);

            int? myNum = HttpContext.Session.GetInt32("LuckyNumber"); //this session data could be null and an int can't be so you need the ?
            int myOtherNum = 10;
            int add = (int)myNum + myOtherNum; //type casting myNum as an int in order to work with it

            //Stage2: Need to GET session
            ViewBag.User = HttpContext.Session.GetString("LoggedInUser");
            return View();
        }

        [HttpGet("Second")]
        public IActionResult Second()
        {
            ViewBag.User = HttpContext.Session.GetString("LoggedInUser");
            ViewBag.LuckyNumber = HttpContext.Session.GetInt32("LuckyNumber");
            return View();
        }

        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Second");
        }
    }
}
