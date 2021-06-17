using System;
using System.Collections.Generic;

namespace Project0BLayer.AppModels
{
    public class OrderModel
    {
        public OrderModel()
        {

        }
        public OrderModel(int orderId, int orderAccount, int orderStoreId, int? numberofProducts)
        {
            OrderId = orderId;
            OrderAccount = orderAccount;
            OrderStoreId = orderStoreId;
            NumberofProducts = numberofProducts;
        }

        public int OrderId { get; set; }
        public int OrderAccount { get; set; }
        public int OrderStoreId { get; set; }
        public int? NumberofProducts { get; set; }

    }//EOC                                  

}//EON
