using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing.Text;

namespace E_Commerce_Playground.Models
{
    public class LoginModel
    {

        private readonly HttpContext _context; 
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginModel(string username, string password, HttpContext context)
        {
            Username = username;
            Password = password;
            _context = context;
            
        }

        public void Method()
        {


            var httpData = _context.Request.Cookies.ToList();
            for (int i = 0; i < httpData.Count; i++)
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
                    contains = false;
                }
                var username = "";
                if (contains)
                {
                    username = d.Value.ToString();
                    
                }
                

            }





        
                
            }

























    }
}
