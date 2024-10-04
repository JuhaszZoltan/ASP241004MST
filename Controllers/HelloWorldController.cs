using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "ez a 'hello world' controller 'index' actionja";
        }

        public string Welcome(string name, int age = 14)
        {
            return $"Szia, {name} {((age < 18) ? "mennyé' haza, ez nem neked való" : "ingyen cukorka a tranzitban")}";
        }
    }
}
