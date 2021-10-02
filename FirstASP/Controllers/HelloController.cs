using Microsoft.AspNetCore.Mvc;

namespace FirstASP.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
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
    }
}