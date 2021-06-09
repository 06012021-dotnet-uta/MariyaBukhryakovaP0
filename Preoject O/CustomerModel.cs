

namespace Preoject_O
{
    public class CustomerModel: ICustomer
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }

        /// <summary>
        /// Use enum to set default store location.... not sure to do it here or... further on
        /// </summary>
        public void SetStoreLocations(){
            System.Console.WriteLine();
        }
    }
}