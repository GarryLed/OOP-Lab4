
/*
 * Name: Garry Ledwith
 * Date: 07/10/24
 * Description:
 * Lab 4, Q3
Create a class called Bank Account with the following properties – Account Number, Account Holder, Balance. 
Use shorthand properties.  Create a constructor which takes all properties as parameters. 
Create two bank account objects and display the bank details in your program. 
Add methods to deposit and withdraw money from the bank accounts. 
Add a method to display account details and make use of all of these methods using the Console to display the changes.  

  
*/
using Q3;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // currency formatting 
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // create two bank account objects 
            BankAccount account1 = new BankAccount("123456", "Ollie Milan", 100);
            BankAccount account2 = new BankAccount("9876542", "Paul Carty", 500);

           
            // display initial details
            Console.WriteLine(account1.GetAccountDetails());
            // make a deposit to the account 
            Console.WriteLine("Adding 100 euros to the account");
            account1.MakeDeposit(100);
            // display details after a deposit was made
            Console.WriteLine(account1.GetAccountDetails());

            // Account number 2: 
            Console.WriteLine();
            // display initial details
            Console.WriteLine(account2.GetAccountDetails());
            // make a deposit to the account 
            Console.WriteLine("Withdrawing 300 euros from the account");
            account2.MakeWithdrawl(300);
            // display details after a deposit was made
            Console.WriteLine(account2.GetAccountDetails());
        }
    }
}