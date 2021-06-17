using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0BLayer.AppModels
{
    class LocationsModel
    {
        public LocationsModel() { }
        public LocationsModel(int storeId, string storeName, long? storePhone, string storeStreetAd, string storeCitytAd, string storeStateAd)
        {
            StoreId = storeId;
            StoreName = storeName;
            StorePhone = storePhone;
            StoreStreetAd = storeStreetAd;
            StoreCitytAd = storeCitytAd;
            StoreStateAd = storeStateAd;
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public long? StorePhone { get; set; }
        public string StoreStreetAd { get; set; }
        public string StoreCitytAd { get; set; }
        public string StoreStateAd { get; set; }

    }
}
