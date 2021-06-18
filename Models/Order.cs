using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public class Order
    {
        public int Tracking { get; set; }
        public string OrderId { get; set; }
        public int OrderAccountId { get; set; }
        public int OrderStoreId { get; set; }
        public int OrderProductId { get; set; }
        public int? OrderProductQantity { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Customer OrderAccount { get; set; }
        public virtual Store OrderNavigation { get; set; }
        public virtual Product OrderProduct { get; set; }

     
    }
}
