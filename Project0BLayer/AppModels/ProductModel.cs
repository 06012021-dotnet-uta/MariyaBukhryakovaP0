using System.Collections.Generic;

namespace Project0BLayer.AppModels
{
    public class ProductModel
    {
        public ProductModel(int productId, string productName, decimal productPrice, string productDescription, string department)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductDescription = productDescription;
            Department = department;
        }
        public bool ItemWasAddedToCart { get; private set; }
        public int ProductId { get; set; } = 0;
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string Department { get; set; }


    }//EOC
}//EON