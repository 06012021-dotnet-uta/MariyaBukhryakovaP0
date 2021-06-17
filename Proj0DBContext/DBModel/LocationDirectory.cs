using System;
using System.Collections.Generic;

#nullable disable

namespace Proj0DBContext
{
    public partial class LocationDirectory
    {
        public LocationDirectory()
        {
            Orders = new HashSet<Order>();
            Stores = new HashSet<Store>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public long? StorePhone { get; set; }
        public string StoreStreetAd { get; set; }
        public string StoreCitytAd { get; set; }
        public string StoreStateAd { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
