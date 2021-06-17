using Project0Blayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0
{
    class Program
    {

        static void Main(string[] args)
        {
            //Func<string> GettingUserAccountInfo;
            //GettingUserAccountInfo getInfo = new GettingUserAccountInfo();
            AccountAccess account = new AccountAccess();
            int store = 0;
            //int accoutID = 0;
            int input = 0;
            string setusername = "";
            ///this is the outter most loop, at end will change to n
            string stayLoggedIn = "y";
            do
            {
                #region this is for user log in, and registration
                while (input == 0)
                {

                    input = account.WelcomeMessage();
                    if (input == 1)
                    {
                        store = account.HasAccessExistingAccount(input, out setusername);
                    }

                    if (input == 2)
                    {
                        string fname = account.getUserFirstName();
                        string Lname = account.getUserLasttName();
                        string username = account.getUserName();
                        string pw = account.getUserPassword();
                        string em = account.getUserEmail();
                        string street = account.getUserStreetAdd();
                        string city = account.getUserCityAdd();
                        string state = account.getUserStateAdd();
                        store = account.getUserStore();
                        account.AddCustomer(fname, Lname, username, pw, em, street, city, state, store, out setusername);
                    }

                }
                #endregion

                #region after log in the user is able to access the account to either shop or go to account options
                AccountInformation myAccount = new AccountInformation(setusername);
                input = myAccount.AccountOptions();
                int userInput = 0;
                if (input == 1)
                {
             
                    userInput = myAccount.AccountHistoryMessage();
                   if(userInput == 1)
                            userInput = myAccount.SearchOtherUser();
                           
                    else if (userInput == 2)
                            userInput = myAccount.DisplayMyOrders(setusername);
                            
                       else if(userInput == 3)
                            userInput = myAccount.DisplayLocationOrders();
                     
                }

                #endregion

                #region Shopping cart, shows inventory, adds items to cart and checks out
                if (input == 2 || userInput == 4)
                {

                    ShoppingCart myCart = new ShoppingCart(store, setusername);
                    //input = myCart.StartShopping(input);
                    myCart.StartShopping(input);
                    myCart.ShowProductsInMyStore(store);
                    myCart.AddItemsToOrder(store);
                    myCart.CheckOut(setusername);
                    if (userInput == 'b') break;
                }

   
                #endregion
                Console.WriteLine("Would you like to log out? Enter N to log out or Y to stay logged in");
                stayLoggedIn = Console.ReadLine();
                Console.WriteLine("Thank you for shopping with us!");
            } while (stayLoggedIn.Equals("y"));
           
      
        }//EOM

    }//EOC
}//EON
