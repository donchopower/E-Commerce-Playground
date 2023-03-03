namespace E_Commerce_Playground.Models
{
    public class Stores_Products
    {
        public int StoreId { get; set; }
        public Store Store { get; set; }


        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
