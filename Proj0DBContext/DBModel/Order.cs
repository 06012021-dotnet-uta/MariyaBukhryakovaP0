using System;
using System.Collections.Generic;

#nullable disable

namespace Proj0DBContext
{
    public partial class Order
    {
        public int Tracking { get; set; }
        public string OrderId { get; set; }
        public int OrderAccount { get; set; }
        public int OrderStoreId { get; set; }
        public int OrderProductId { get; set; }
        public int? NumberofProducts { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Customer OrderAccountNavigation { get; set; }
        public virtual Product OrderProduct { get; set; }
        public virtual LocationDirectory OrderStore { get; set; }
    }
}
