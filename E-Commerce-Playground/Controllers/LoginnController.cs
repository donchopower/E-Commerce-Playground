using E_Commerce_Playground.Data;
using E_Commerce_Playground.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.IdentityModel.Tokens;

namespace E_Commerce_Playground.Controllers
{
    public class LoginnController : Controller
    {
        private readonly AppDbContext _context;

        public LoginnController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Login()
        {
            return View();
        }









    }

}

   

