using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Playground.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
