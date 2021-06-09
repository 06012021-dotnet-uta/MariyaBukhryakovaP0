namespace Preoject_O
{
    public interface ICustomer
    {
       
        /// <summary>
        /// BluePrint of a customer
        /// </summary>
        /// <value></value>
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }

        /// <summary>
        /// Created enum with store locations....
        /// </summary>
        public void SetStoreLocations();
            
    }
}