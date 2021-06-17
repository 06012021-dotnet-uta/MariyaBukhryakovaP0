using System.Collections.Generic;

namespace Project0BLayer.AppModels
{
    public class StoreModel
    {
        public StoreModel(int storeNums, int storeId1, int productInventory, int storeProductId)
        {
            StoreNums = storeNums;
            StoreId1 = storeId1;
            ProductInventory = productInventory;
            StoreProductId = storeProductId;
        }

        public int StoreNums { get; set; }
        public int StoreId1 { get; set; } = 100;
        public int ProductInventory { get; set; }
        public int StoreProductId { get; set; }
}
}