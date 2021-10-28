using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OneToMany.Models;
using Microsoft.EntityFrameworkCore;

namespace OneToMany.Controllers
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
            ViewBag.AllShips = _context.Ships.ToList();
            ViewBag.AllPirates = _context.Pirates.Include(s => s.Ship).ToList();
            ViewBag.AllPets = _context.Pets.Include(p => p.Owner).ToList();
            return View();
        }
        
        [HttpPost("addShip")]
        public IActionResult addShip(Ship newShip)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newShip);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                ViewBag.AllShips = _context.Ships.ToList();
                ViewBag.AllPirates = _context.Pirates.Include(s => s.Ship).ToList();
                ViewBag.AllPets = _context.Pets.Include(p => p.Owner).ToList();
                return View("Index");
            }
        }

        [HttpPost("addPirate")]
        public IActionResult addPirate(Pirate newPirate)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newPirate);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                ViewBag.AllShips = _context.Ships.ToList();
                ViewBag.AllPirates = _context.Pirates.Include(s => s.Ship).ToList();
                ViewBag.AllPets = _context.Pets.Include(p => p.Owner).ToList();
                return View("Index");
            }
        }

        [HttpPost("addPet")]
        public IActionResult addPet(Pet newPet)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newPet);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                ViewBag.AllShips = _context.Ships.ToList();
                ViewBag.AllPirates = _context.Pirates.Include(s => s.Ship).ToList();
                ViewBag.AllPets = _context.Pets.Include(p => p.Owner).ToList();
                return View("Index");
            }
        }
    }
}
