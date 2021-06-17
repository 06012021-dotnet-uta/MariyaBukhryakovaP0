namespace Project0BLayer.AppModels
{
    public interface ICustomerModel
    {

        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string AccountUserName { get; set; }
        public string PassWord { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerStreet { get; set; }
        public string CustomerCityt { get; set; }
        public string CustomerState { get; set; }
        public int AcStore { get; set; }


    }
}