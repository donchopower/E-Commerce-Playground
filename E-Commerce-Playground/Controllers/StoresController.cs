using E_Commerce_Playground.Data;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Playground.Controllers
{
    public class StoresController : Controller
    {

        private readonly AppDbContext _context;

        public StoresController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var data = _context.Stores.ToList();
            return View();
        }
    }
}
