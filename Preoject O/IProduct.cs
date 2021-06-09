namespace Preoject_O
{
    public interface IProduct
    {
        /// <summary>
        /// BluePrint of product
        /// </summary>
        /// <value></value>    
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public int Quantity { get; set; }
}
}