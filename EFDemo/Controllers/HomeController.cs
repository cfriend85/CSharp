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

        [HttpGet("delete/{GameID}")]
        public IActionResult Delete(int GameID) //DELETE
        {
            Game gameToDelete = _context.Games.SingleOrDefault(g => g.GameId == GameID);
            _context.Games.Remove(gameToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{GameID}")]
        public IActionResult UpdateGame(int GameID) //Get update form and prepopulate
        {
            Game gameToEdit = _context.Games.FirstOrDefault(g => g.GameId == GameID);
            return View(gameToEdit);
        }

        [HttpPost("update/{GameID}")]
        public IActionResult UpdatedGame(int GameID, Game updatedGame) //ID and form data as params
        {
            Game GameToEdit = _context.Games.FirstOrDefault(g => g.GameId == GameID);
            GameToEdit.Title = updatedGame.Title;
            GameToEdit.Price = updatedGame.Price;
            GameToEdit.Rating = updatedGame.Rating;
            GameToEdit.ReleaseDate = updatedGame.ReleaseDate;
            GameToEdit.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
