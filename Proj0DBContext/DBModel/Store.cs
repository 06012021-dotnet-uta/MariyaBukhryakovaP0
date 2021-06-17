using System;
using System.Collections.Generic;

#nullable disable

namespace Proj0DBContext
{
    public partial class Store
    {
        public int StoreNums { get; set; }
        public int StoreId1 { get; set; }
        public int ProductInventory { get; set; }
        public int StoreProductId { get; set; }

        public virtual LocationDirectory StoreId1Navigation { get; set; }
        public virtual Product StoreProduct { get; set; }
    }
}
