using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class CashRegister
    {
        // class level variables (available at the class level) 
        public static decimal totalMoneyForAllCashRegisters {  get; set; }

        public static int totalItemsForAllCashRegisters { get; set; }

        // properties 
        public decimal Total { get; private set; }

        public int NumberOfItems { get; private set; }

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

            totalMoneyForAllCashRegisters += price; // increments total money for all cash registers 
            totalItemsForAllCashRegisters++; // incremetns total items for all cash registes 
        }
    }
}
