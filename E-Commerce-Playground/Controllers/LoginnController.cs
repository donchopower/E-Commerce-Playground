using E_Commerce_Playground.Data;
using E_Commerce_Playground.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;

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
        //public void FindThisForMe()
        //{
        //    var data = _context.Users.ToList();
        //    if (data[0].Email)

        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User user)
        {
            var input = user;
            var data = _context.Users.ToList();
            foreach(var item in data)
            {
                if (item.Email.Contains(input.Email) && item.Password.Contains(input.Password))
                {
                    return View();
                }
                return RedirectToAction("Index");
            }


            return RedirectToAction("Redirect");


        }


        public IActionResult Redirect()
        {
            return View();
        }






    }

}

   

