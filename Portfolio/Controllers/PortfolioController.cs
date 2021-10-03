using Microsoft.AspNetCore.Mvc;
using System;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet("")]
        public string Index()
        {
            return "This is my index!";
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