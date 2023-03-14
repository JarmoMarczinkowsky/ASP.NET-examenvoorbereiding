using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Pizzaplace.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Gutentag()
        {
            return "Hello";
        }
    }
}
