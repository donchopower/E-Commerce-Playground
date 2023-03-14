using E_Commerce_Playground.Data;
using E_Commerce_Playground.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Drawing.Text;

namespace E_Commerce_Playground.Controllers
{
    public class AdminController : Controller
    {

        private readonly AppDbContext _context;
        static int TotalUsers { get; set; }
        static int TotalProducts { get; set; }
        static int TotalStores { get; set; }
        private List<int> totals { get; set; }

       
        public AdminController(AppDbContext context) 
        {
            totals = new List<int>();
        _context= context;

            TotalProducts = _context.Products.Count();
            TotalUsers = _context.Users.Count();
            TotalStores = _context.Stores.Count();
            totals.Add(TotalUsers);
            totals.Add(TotalProducts);
            totals.Add(TotalStores);
        
        
        }

        public static int GetUsers()
        {
            return TotalUsers;
        }
        public static int GetStores()
        {
            return TotalStores;
        }
        public static int GetProducts()
        {
            return TotalProducts;
        }
        public IActionResult Index()
        {

            var totaldata = GetUsers();
            
            return View();
        }


        public IActionResult Users()
        { var data = _context.Users.ToList();
            return View(data);
        }

    }
}
