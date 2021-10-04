using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            List<string> myWords = new List<string>();
            myWords.Add("Hot");
            myWords.Add("Pocket");
            myWords.Add("Smores");

            ViewBag.Words = myWords;
            
            return View();
        }

        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects!";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }
    }
}