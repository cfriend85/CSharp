using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
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
            List<Dish> AllDishes = _context.Dishes.ToList();
            ViewBag.Dishes = AllDishes;
            return View();
        }

        [HttpGet("AddDish")]
        public IActionResult AddDish()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult NewDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("AddDish");
            }
        }

        [HttpGet("view/{DishId}")]
        public IActionResult OneDish(int DishId)
        {
            ViewBag.OneDish = _context.Dishes.FirstOrDefault(d => d.DishId == DishId);
            return View();
        }

        [HttpGet("edit/{DishId}")]
        public IActionResult UpdateDish(int DishId)
        {
            Dish DishToEdit = _context.Dishes.FirstOrDefault(d => d.DishId == DishId);
            @ViewBag.EditDish = DishToEdit;
            return View(DishToEdit);
        }

        [HttpPost("update/{DishId}")]
        public IActionResult UpdatedDish(int DishId, Dish updatedDish)
        {
            Dish Dish = _context.Dishes.FirstOrDefault(d => d.DishId == DishId);
            Dish.Name = updatedDish.Name;
            Dish.Chef = updatedDish.Chef;
            Dish.Tastiness = updatedDish.Tastiness;
            Dish.Calories = updatedDish.Calories;
            Dish.Description = updatedDish.Description;
            Dish.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("delete/{DishId}")]
        public IActionResult DeleteDish(int DishId)
        {
            Dish DishToDelete = _context.Dishes.SingleOrDefault(d => d.DishId == DishId);
            _context.Dishes.Remove(DishToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
