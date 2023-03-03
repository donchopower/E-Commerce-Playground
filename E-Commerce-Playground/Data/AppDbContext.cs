using E_Commerce_Playground.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Playground.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Stores_Products>().HasKey(sp => new
            {
                sp.StoreId,
                sp.ProductId
            });

            modelBuilder.Entity<Stores_Products>().HasOne(s => s.Store).WithMany(sp => sp.StoreProducts).HasForeignKey(s => s.StoreId).IsRequired();
            modelBuilder.Entity<Stores_Products>().HasOne(p => p.Product).WithMany(sp => sp.StoreProducts).HasForeignKey(p => p.ProductId).IsRequired();


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Employee> Employees { get;set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Stores_Products> StoresProducts { get; set; }
        public DbSet<User> Users { get; set; }


        
    }
}
