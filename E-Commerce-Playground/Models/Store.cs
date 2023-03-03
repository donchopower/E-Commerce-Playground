using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Playground.Models
{
    public class Store
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string StoreName { get; set; }
        [Required]
        public string StoreLocation { get; set; }
        
        public string StoreContactNumber { get; set; }

        //Relationships

        public List<Stores_Products> StoreProducts { get; set; }

        public List<Employee> Employees { get; set; }

    }
}
