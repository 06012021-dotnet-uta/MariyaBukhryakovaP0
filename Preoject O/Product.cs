namespace Preoject_O
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public int Quantity { get; set; }
    }
}