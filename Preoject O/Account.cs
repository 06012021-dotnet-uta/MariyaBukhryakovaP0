using System; 
using System.Collections.Generic;

namespace Preoject_O
{
    public abstract class Account 
    {
        /// <summary>
        /// Prompting the user to register and a returen message for each field... do I want that?!
        /// </summary>
        
        List<Person> ListOfAccounts = new List<Person>();
        public void CreateNewAccount(){
//need to get a delegate
             
        }
          public string GetCustomerFristName(string FristName){
             
             return $"Thank you { FristName }";
        }

         public string GetCustomerLastName(string LastName){
             
             return $"Thank you { LastName }";
        }
        public string GetCustomerEmail(string EmailInput){
             
             return $"Thank you your email is{ EmailInput }";
        }
        public string GetCustomerPhone(long PhoneNumber){
             
             return $"Thank you your phone numnber is{ PhoneNumber }";
        }
        public string GetCustomerLocation(int LocationChoice){
             
             return $"Your Location is { LocationChoice }";
        }


        /// <summary>
        /// create an account and posibly check for matches
        /// take infor in and also set the default store location
        /// </summary>
        public abstract void CreateAccount();

        /// <summary>
        /// Create a list of the accounts.
        /// </summary>
        public abstract void StoreAccount();

        /// <summary>
        /// Log in and or retrieve account
        /// </summary>
        public abstract void AccessAccount();

        /// <summary>
        /// Need to store shopping history...
        /// </summary>
        public abstract void StoreShoppingHistory();
        

    }
}