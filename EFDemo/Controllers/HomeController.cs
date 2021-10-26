using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EFDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDemo.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        public IActionResult Index()
        {
            //READ ALL
            List<Game> AllGames = _context.Games.ToList();
            ViewBag.AllGames = AllGames;
            return View();
        }

        [HttpGet("AddGame")]
        public IActionResult AddGame()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Game newGame) //CREATE
        {
            if(ModelState.IsValid)
            {
                _context.Add(newGame);
                _context.SaveChanges();
            return RedirectToAction("Index");
            } else {
                return View("AddGame");
            }
        }

        [HttpGet("view/{GameID}")]
        public IActionResult ViewGame(int GameID) //READ ONE
        {
            ViewBag.OneGame = _context.Games.FirstOrDefault(g => g.GameId == GameID);
            return View();
        }
    }
}
