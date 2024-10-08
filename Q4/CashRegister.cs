/*
 * Create an application named TestCashRegister that instantiates and displays a CashRegister object.
The CashRegister class contains a field for a total (a decimal) and a field for the number of items (an integer). 
The CashRegister class has a method called AddItem that takes in a price, adds it to the total and increments the number of items.
The class should include properties with only a getter (no setter) to get a Cash Registers total cash price and number of items. 
Create several CashRegister objects, add a number of items to each and print out the total price and number of items per cash register.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class CashRegister
    {
        
        
        // properties 
        public decimal Total { get; private set; }

        public int NumberOfItems { get; private set;  }

        // Method 
        // AddItem method
        /// <summary>
        /// takes in a price 
        /// adds price to total 
        /// increments number of items 
        /// </summary>
        public void AddItem(decimal price)
        {
            Total += price;
            NumberOfItems++;
        }
    }
}
