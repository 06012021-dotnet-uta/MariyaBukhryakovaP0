
//using Microsoft.EntityFrameworkCore;

//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;

//namespace Project0Blayer
//{
//    public class ShoppingCart
//    {
//        /// <summary>
//        /// sets store ID from Account Access
//        /// </summary>
//        /// <param name="storeID">from account registration/log in</param>
//        public ShoppingCart(int storeID, string userName)
//        {
//            this.StoreID = storeID;
//            this.MyUserName = userName;
//        }
//        public string MyUserName { get; set; }
//        public int StoreID { get; set; }
//        public int ProductID { get; set; }
//        public int ItemsLeft { get; set; } 
//        public Project0Context _context = new Project0Context();
//        /// <summary>
//        /// Create dictionary to store prod ID and prod qt, and set up a random var to create order ID
//        ///// </summary>
//        public Dictionary<int, int> MyOrder = new Dictionary<int, int>();
//        public int OrderNumber { get; set; } = 101010;
//        //r.Next(1000,1000000);-random num for orderID
//        /// <summary>
//        /// This will use store ID to show list of products in store with all details
//        /// </summary>
//        public void StartShopping(int userInput)
//        {
//            //int input = 0;
//            var myStore = _context.LocationDirectories.ToList().Where(x => x.StoreId == StoreID);
//            foreach (var store in myStore)
//            {

//                Console.WriteLine("***************************************************");
//                Console.WriteLine($"Welcome to {store.StoreName}!!!" +
//                                 "\n***************************************************");
//                /*"\nIf you want to start a new order Enter 4 to start an order or 9 to return to main menu")*/
//                ;
//                //input = Convert.ToInt32(Console.ReadLine());

//                //    if (input != 4 && input != 9)
//                //    {
//                //        Console.WriteLine("That is not a valid entry please type 0 to return to main menu or 3 to start order\n");
//                //        return 0;
//                //    }
//                //}
//                //return input;
//            }
//        }

//        public void ShowProductsInMyStore(int storeID)
//        {
//            var myStore = _context.Stores.Where(z => z.StoreId1 == StoreID).ToList();
//            foreach (var item in myStore)
//            {
//                var myProduct = _context.Products.Where(x => x.ProductId == item.StoreProductId).ToList();
//                foreach (var product in myProduct)
//                {
//                    //decimal price = Convert.ToDecimal(product.ProductPrice);
//                    Console.WriteLine("**********************************************************");
//                    Console.WriteLine($"ItemID: {item.StoreProductId} Qantity Available: {item.ProductInventory}");
//                    Console.WriteLine(" Price of Item {0:C}" , product.ProductPrice);
//                    Console.WriteLine($"Department: { product.Department} Description: { product.ProductDescription}");
//                    Console.WriteLine("**********************************************************");
                  
//                }
//            }

//        }
//            /// <summary>
//            /// Add Items to order and check to make sure item has enough stock
//            /// </summary>
//            /// <param name="userStore"></param>
//        public void AddItemsToOrder(int storeID)
//        {
//            int input = 1;
//            int IDtoCart = 0;
//            int InventorytoCart = 0;
//            decimal total = 0.00M;
//            Store store = new Store();
            
//            var myStore = _context.Stores.Include(a => a.StoreProduct).ToList();

//            do
//            {
//            Console.WriteLine("**********************************************************");
//            Console.WriteLine("Please enter the ProductID you want to add to your order:");
//            Console.WriteLine("**********************************************************");
//            IDtoCart = Convert.ToInt32(Console.ReadLine());
//                foreach (var item in myStore)
//                {
//                    if (item.StoreProduct.ProductId != IDtoCart)
//                        //{
//                        //    Console.WriteLine("That is not a valid entry please type in the product ID");
//                        //}
//                    Console.WriteLine($"You chose {item.StoreProduct.ProductName}");
//                    Console.WriteLine("Please enter the ammount of items you want to add to your cart:");
//                    InventorytoCart = Convert.ToInt32(Console.ReadLine());
//                    if (item.ProductInventory < InventorytoCart)
//                    {
//                        Console.WriteLine($"You entered {InventorytoCart}, and your current store only has {item.ProductInventory}.\nPlease input a valid quantity.");
//                    }
//                    else if (item.ProductInventory >= InventorytoCart)
//                    {
//                        Console.WriteLine($"Your chose: {InventorytoCart} items. ");
//                        Console.WriteLine("Price per item {0:C} ", item.StoreProduct.ProductPrice);
//                        Console.WriteLine($"Department: {item.StoreProduct.Department} Description: {item.StoreProduct.ProductDescription}");
//                        Console.WriteLine("Enter 6 if you want to add another item, or 9 if you want to check out");
//                        input = Convert.ToInt32(Console.ReadLine());
//                        MyOrder.Add(item.StoreProduct.ProductId, item.ProductInventory);
//                        decimal productTimesQt = 0.00m;
//                        productTimesQt = item.StoreProduct.ProductPrice * InventorytoCart;
//                        total = productTimesQt * InventorytoCart;
//                        if (input == 9) break;
//                    }
                    
//                    }
                
//                Console.WriteLine("Your order total is {0:C}", total);
//            } while (input == 6);

//        }

       

//        public void CheckOut(string userName)
//        {
            
//            string orderID = OrderNumber.ToString();
//            int itemsLeftInstock = 0;
//            var acctIDD = _context.Customers.Where(z => z.AccountUserName == userName).Select(y => y.CustomerId);
       
//            foreach(KeyValuePair<int,int> kvp in MyOrder) 
//        {
//                Store store = new Store()
//                {
//                   StoreId1 = StoreID,
//                   //ProductInventory =  kvp.Value - ProductInventory,


//                };
//                Order order = new Order()
//                {
//                    OrderId = orderID,
//                    OrderAccount = acctID,
//                    OrderProductId = kvp.Key,
//                    OrderStoreId = StoreID,
//                    NumberofProducts = kvp.Value

//                };
//                _context.Orders.Add(order);
//            }
           
//            _context.SaveChanges();
//            OrderNumber += 1010;
//        }

//    }//EOC
//}//EON;
