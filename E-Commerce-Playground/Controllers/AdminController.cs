using E_Commerce_Playground.Data;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace E_Commerce_Playground.Controllers
{
    public class AdminController : Controller
    {

        private readonly AppDbContext _context;
        public AdminController(AppDbContext context) 
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
