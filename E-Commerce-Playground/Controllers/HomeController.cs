using E_Commerce_Playground.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_Commerce_Playground.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }

        public IActionResult Index()
        {
            var data = _logger.ToString();
            var httpData = HttpContext.Request.Cookies.ToList();
            for(int i = 0; i < httpData.Count; i++)
            {
                var d = httpData[i];
                var matchCondition = "MyCookie";
                bool contains = false;
                    if (d.Key.Contains(matchCondition))
                {
                    contains = true;
                }
                else
                {
                    contains= false;
                }
                var username = "";
               if (contains)
                {
                    username = d.Value.ToString();
                    return View(username);
                }
                return View();
                
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}