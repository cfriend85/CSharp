using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.WomensLeagues = _context.Leagues
            .Where(l => l.Name.Contains("Womens")).ToList();
            ViewBag.HockeyLeagues = _context.Leagues
            .Where(l => l.Sport.Contains("Hockey")).ToList();
            ViewBag.NotFootball = _context.Leagues
            .Where(l => !l.Sport.Contains("Football")).ToList();
            ViewBag.Conferences = _context.Leagues
            .Where(l => l.Name.Contains("Conference")).ToList();
            ViewBag.Atlantic = _context.Leagues
            .Where(l => l.Name.Contains("Atlantic")).ToList();
            ViewBag.DallasTeams = _context.Teams
            .Where(t => t.Location.Contains("Dallas")).ToList();
            ViewBag.Raptors = _context.Teams
            .Where(t => t.TeamName.Contains("Raptors")).ToList();
            ViewBag.Cities = _context.Teams
            .Where(t => t.Location.Contains("City")).ToList();
            ViewBag.T = _context.Teams
            .Where(t => t.TeamName.Contains("T")).ToList();
            ViewBag.Alpha = _context.Teams
            .OrderBy(t => t.Location).ToList();
            ViewBag.Reverse = _context.Teams
            .OrderByDescending(t => t.TeamName).ToList();
            ViewBag.Coopers = _context.Players
            .Where(p => p.LastName.Contains("Cooper")).ToList();
            ViewBag.Joshuas = _context.Players
            .Where(p => p.FirstName.Contains("Joshua")).ToList();
            ViewBag.Specific = _context.Players
            .Where(p => p.LastName.Contains("Cooper")).Where(p => !p.FirstName.Contains("Joshua")).ToList();
            ViewBag.Firsts = _context.Players
            .Where(p => p.FirstName.Contains("Alexander") || p.FirstName.Contains("Wyatt")).ToList();
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}