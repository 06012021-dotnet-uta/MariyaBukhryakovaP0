namespace Project0BLayer.AppModels
{
    public interface IProductModel
    {
        /// <summary>
        /// BluePrint of product
        /// </summary>
        /// <value></value>    
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string Department { get; set; }
    }
}