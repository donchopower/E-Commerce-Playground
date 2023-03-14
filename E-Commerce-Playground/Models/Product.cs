using E_Commerce_Playground.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Playground.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "ProductPictureURL")]
        public string ProductPictureURL { get; set; }
        [Required]
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductColor { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public ProductCategory Category { get; set; }

        //Relations

        public List<Stores_Products> StoreProducts { get; set; }
   


    }
}
