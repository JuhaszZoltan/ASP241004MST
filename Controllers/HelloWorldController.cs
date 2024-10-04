using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int age = 14)
        {
            ViewData["Name"] = name;
            ViewData["Age"] = age;
            return View();
        }

        public string Goodbye(int id = 10)
        {
            return $"az 'id', amit paraméterben kaptam {id}";
        }
    }
}
