using E_Commerce_Playground.Data;
using E_Commerce_Playground.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Security.Claims;

namespace E_Commerce_Playground.Controllers
{
    public class LoginnController : Controller
    {
        private readonly AppDbContext _context;
        private readonly HttpResponseMessage _message;



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
        public async Task< IActionResult> Login(User user)
        {
            var input = user;
            var data = _context.Users.ToList();
            foreach(var item in data)
            {
                if (item.UserName.Contains(input.UserName) && item.Password.Contains(input.Password))
                {
                    var options = new CookieOptions();
                    
                        options.IsEssential = true;
                    options.Expires = DateTimeOffset.UtcNow.AddMinutes(5);
                    options.Secure = true;
                    HttpContext.Response.Cookies.Append("MyCookie", input.UserName, options);
                    
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

   

