using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Pizzaplace.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name = "silent", int numTimes = 21, string message = "nothing")
        {
            ViewData["Message"] = $"Hello {name}";
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
