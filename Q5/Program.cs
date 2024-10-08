/*
 * Name: Garry Ledwith
 * Date: 07/10/24
 * Description:
 * Lab 4, Q5
The store manager wants to know how much money and how many items have gone through all his cash registers today.
Make a copy of the CashRegister class and put it in a new project.  
Add two static variables, one to hold the total cash amount from all CashRegister objects
the second to hold the total number of items from all CashRegister objects. 
Update the class as appropriate so these two new static variables are updated anytime
any Cash Register handles an item. Output these total results.  

  
*/
namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // currency formatting 
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // create a CashRegister object 
            CashRegister cashregister1 = new CashRegister();

            // add items to cash register 1 
            Console.WriteLine("Adding an item worth 4.50 to Cash Register 1");
            cashregister1.AddItem(4.50m);
            Console.WriteLine("Adding an item worth 5.60 to Cash Register 1");
            cashregister1.AddItem(5.60m);
            Console.WriteLine("Adding an item worth 7.23 to Cash Register 1");
            cashregister1.AddItem(7.23m);


            // create a second CashRegister object 
            CashRegister cashregister2 = new CashRegister();

            // add items to cash register 2 
            Console.WriteLine("Adding an item worth 3.30 to Cash Register 2");
            cashregister2.AddItem(3.30m);
            Console.WriteLine("Adding an item worth 1.80 to Cash Register 2");
            cashregister2.AddItem(1.80m);
            Console.WriteLine("Adding an item worth 2.90 to Cash Register 2");
            cashregister2.AddItem(2.90m);

            // print out the total price and number of items per cash register
            Console.WriteLine("Cash Register CashRegister1 Total: {0}", cashregister1.Total);
            Console.WriteLine("Cash Register CashRegister1 Number of Items: {0}", cashregister1.NumberOfItems);
            Console.WriteLine(); // line break 
            Console.WriteLine("Cash Register CashRegister2 Total: {0}", cashregister2.Total);
            Console.WriteLine("Cash Register CashRegister2 Number of Items: {0}", cashregister2.NumberOfItems);
            Console.WriteLine(); // line break 
            Console.WriteLine("Total money from all cash registers: {0}", CashRegister.totalMoneyForAllCashRegisters);
            Console.WriteLine("Total items from all cash registers: {0}", CashRegister.totalItemsForAllCashRegisters);
        }
    }
}