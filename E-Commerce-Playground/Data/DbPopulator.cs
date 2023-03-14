using E_Commerce_Playground.Data.Enums;
using E_Commerce_Playground.Models;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace E_Commerce_Playground.Data
{
    public class DbPopulator
    {

        public static void Populate(IApplicationBuilder appBuilder)
        {

            using (var serviceScope = appBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Employees.Any())
                {
                    context.Employees.AddRange(new List<Employee>()
                    {
                        new Employee()
                        {
                            Firstname = "John",
                            Lastname = "Smith",
                            PhoneNumber = "078965253",
                            Email = "mail@me.com",
                            EmploymentAddress = "StoreAddress",
                            EmploymentLevel = Enums.EmploymentLevel.StoreEmployee,
                            Salary = 800
                        },
                        new Employee()
                        {
                            Firstname = "Kiro",
                            Lastname = "Baltiqta",
                            PhoneNumber = "0000000000",
                            Email = "shefanachuknorris@boss.com",
                            EmploymentAddress = "WorldWide",
                            EmploymentLevel = Enums.EmploymentLevel.Owner,
                            Salary = 8000000000
                        }

                    });
                    context.SaveChanges();

                }

                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            ProductPictureURL = "https://www.dhresource.com/webp/m/0x0/f2/albu/g5/M00/47/99/rBVaI1lSCxqAFDSFAAG5gNA7eBk406.jpg",
                            ProductName = "prashki s hui",
                            ProductDescription = "za postoqnna stimulaciq",
                            ProductColor = "shareni",
                            Quantity = 50,
                            Price = 29.90M,
                            Category = ProductCategory.WomensClothing
                         },

                        new Product()
                        {
                            ProductPictureURL = "https://imgs.search.brave.com/Nosa3ZQtq1JPXNm_J2XQx-yYUOmzTWOPibUtgYYfvE0/rs:fit:600:600:1/g:ce/aHR0cHM6Ly9wbGF0/by5iZy9pbWFnZXMv/cHJvZHVjdHMva29t/cGxla3Qtbm9rdG9y/ZXphY2hrYS1pLXBp/bGljaGthLXphLWRv/bWFzaG5pLWx5dWJp/bXRzaS00ODgyMi02/MWMxY2M0YTBhMTVh/LmpwZw",
                            ProductName = "noktorezachka za jivotni",
                            ProductDescription = "udobna za rqzane na nokti za kucheta i kotki",
                            ProductColor = "rozova",
                            Quantity = 50,
                            Price = 5,
                            Category = ProductCategory.Homeware
                         }



                    });
                    context.SaveChanges();
                }

                if (!context.Stores.Any())
                {
                    context.Stores.AddRange(new List<Store>()
                    {
                        new Store()
                        {
                            StoreName = "denonoshten magazin",
                            StoreLocation = "gorna na nadolnishte 69",
                            StoreContactNumber = "ebi se v guz"
                        },
                        new Store()
                        {
                            StoreName = "lafka",
                            StoreLocation = "pred uchilishteto",
                            StoreContactNumber = "0000000"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.StoresProducts.Any())
                {
                    context.StoresProducts.AddRange(new List<Stores_Products>()
                    {
                        new Stores_Products()
                        {
                            StoreId= 1,
                            ProductId= 1,
                        },
                        new Stores_Products()
                        {
                            StoreId= 1,
                            ProductId= 2,
                        },
                         new Stores_Products()
                        {
                            StoreId= 2,
                            ProductId= 1,
                        },
                          new Stores_Products()
                        {
                            StoreId= 2,
                            ProductId= 2,
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<User>()
                    {
                        new User()
                        {
                            UserName = "Admin",
                            Password = "Admin",
                            Email = "na@dmin0.poshtata",
                            PhoneNumber = "000000000",
                             ProfilePictureURL = "asd",
                            AccountLevel = AccountType.Admin
                        },
                        new User()
                        {
                            UserName = "user",
                            Password = "user",
                            Email = "p0sht@.me",
                            PhoneNumber = "00000000",
                            ProfilePictureURL = "asds",
                           AccountLevel = AccountType.User
                        },
                    });;
                    context.SaveChanges();

                }

                


            }
        }
    }
}