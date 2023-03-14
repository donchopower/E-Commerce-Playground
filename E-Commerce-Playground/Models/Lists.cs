using E_Commerce_Playground.Data;
using Microsoft.AspNetCore.Http;

namespace E_Commerce_Playground.Models
{
    public class Lists
    {

  private readonly AppDbContext _context;
       
        public int TotalUsers { get; set; }
        public int TotalStores { get; set; }
        public int TotalProducts { get; set; }

        public Lists()
        {

        }

        public Lists(AppDbContext context)
        {
            _context = context;
        }

        public int GetUsers()
        {
            var users = _context.Users.Count();
            return users;
        }
        public Lists(int users, int stores, int products)

           
        {
            TotalUsers = users;
            TotalStores = stores;
                TotalProducts = products;

        }






    }
}
