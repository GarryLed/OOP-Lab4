/*
 * Name: Garry Ledwith
 * Date: 07/10/24
 * Description:
 * Lab 4, Q4
Create an application named TestCashRegister that instantiates and displays a CashRegister object.
The CashRegister class contains a field for a total (a decimal) and a field for the number of items (an integer). 
The CashRegister class has a method called AddItem that takes in a price, adds it to the total and increments the number of items.
The class should include properties with only a getter (no setter) to get a Cash Registers total cash price and number of items. 
Create several CashRegister objects, add a number of items to each and print out the total price and number of items per cash register.  

----------------------------------
# UNDERSTAND THE PROBLEM: 

    Rules / Requirements: 
    - Explicit requirements
    
    

    - Implicit requirements
     
    

    Clarifying Questions: 
  

  
  
*/
namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
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


        }
    }
}