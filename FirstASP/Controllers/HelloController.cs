using Microsoft.AspNetCore.Mvc;

namespace FirstASP.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Hello from the Index controller!";
        }

        [HttpGet("First")]
        public string First()
        {
            return "Hello from another page!";
        }
    }
}