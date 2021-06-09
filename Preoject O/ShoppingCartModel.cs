using System;
using System.Collections.Generic;

namespace Preoject_O
{
    public class ShoppingCartModel : Store
    {

        /// <summary>
        /// This is what stores my list of products
        /// </summary>
        /// <typeparam name="Product"></typeparam>
        /// <returns></returns>
        public List<Product> startCart = new List<Product>();


        public decimal GetTotal(){

            decimal subTotal = startCart.Sum(x => x.Price);
              



        }

        //public void RecieptToHistory();
    }
}