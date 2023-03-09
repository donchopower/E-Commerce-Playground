using E_Commerce_Playground.Data;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Playground.Controllers
{
    public class ProfileController : Controller
    {
        private readonly AppDbContext _context;

        public ProfileController(AppDbContext context)
        {
            _context= context;

        }


        public IActionResult Index()
        {

            var data = _context.Users.ToList();
            return View(data);
        }
    }
}
