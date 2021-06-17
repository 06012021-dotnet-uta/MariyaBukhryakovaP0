namespace Project0BLayer.AppModels
{

    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string AccountUserName { get; set; }
        public string PassWord { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerStreet { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public int AcStore { get; set; }

        public CustomerModel()
        {

        }

        //public CustomerModel(int customerId, string customerFirstName, string customerLastName, string accountUserName, string passWord, string customerEmail, string customerStreet, string customerCity, string customerState)
        //{
        //    CustomerId = customerId;
        //    CustomerFirstName = customerFirstName;
        //    CustomerLastName = customerLastName;
        //    AccountUserName = accountUserName;
        //    PassWord = passWord;
        //    CustomerEmail = customerEmail;
        //    CustomerStreet = customerStreet;
        //    CustomerCity = customerCity;
        //    CustomerState = customerState;
        //}
    }
}
