using Microsoft.AspNetCore.Mvc;
using System;

namespace FirstASP.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index() //IActionResult could be used as the return type if you wanted to return other things than just a "view"
        {
            ViewBag.WhateverYouWantToCallIt = "Some interesting Fact about an otter";
            return View(); //if view is named the same as the action this is going to imply to render that view
        }

        [HttpGet("First")]
        public string First()
        {
            return "Hello from another page!";
        }

        [HttpGet("Second")]
        public int Second()
        {
            return 2;
        }

        [HttpGet("Landing")]
        public string Landing()
        {
            return "You were redirected!";
        }

        [HttpGet("form")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("sendData")]
        public IActionResult sendData(string TextField, int NumberField) //params are the names of the inputs on the form
        {
            Console.WriteLine($"Text: {TextField}, Number: {NumberField}");
            // return RedirectToAction("Index");
            ViewBag.Text = TextField;
            ViewBag.Number = NumberField;
            return View("Results");
        }

        [HttpGet("Redirect")]
        public RedirectToActionResult Redirect()
        {
            return RedirectToAction("Landing");
        }
    }
}