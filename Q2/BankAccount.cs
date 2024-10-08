/*
 * Create a class called Bank Account with the following properties – Account Number, Account Holder, Balance. 
Use shorthand properties.  Create a constructor which takes all properties as parameters. 
Create two bank account objects and display the bank details in your program. 
Add methods to deposit and withdraw money from the bank accounts. 
Add a method to display account details and make use of all of these methods using the Console to display the changes.
 

----------------------------------
# UNDERSTAND THE PROBLEM: 

    Rules / Requirements: 
    - Explicit requirements
      - create a class called BankAccount
       - properties: 
         - Account Number 
         - Account Holder 
         - Balance 
       - use parameterized constructor 
       - create 2 bank account objects adn display the bank details 
       - add methods: 
        - deposit money 
        - withdraw money 
        - display accouint details 
    

    - Implicit requirements
     - add euro symbol to balances 
    

    Clarifying Questions: 
   - how do i use shorthand properties? 
     - C#'s auto implemented properties 

   - Should I create and increment a unique bank account number for each new object? 
     - the question doesn't ask for this requirement 

   - how should I handle withdrawl that are larger than the current balnace? 
    - I could  create an error message and display it to the console 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class BankAccount
    {
        
        // properties (auto implemented) 
        public string AccountNumber { get; set; }

        public string AccountHolder { get; set; }

        public decimal Balance { get; set; }

        // parameterized constructor 
        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        // instance methods:
        public void MakeDeposit(decimal amount)
        {
            Balance += amount; // the amount will be added to the current balcance 
        }

        // withdrawl method 
        public void MakeWithdrawl(decimal amount) 
        {
            if (Balance >= amount)
            {
                Balance -= amount; // the amount will be subtracted from the current balance     
            }
            
        }

        // get account details method 
        public string GetAccountDetails()
        {
            return string.Format($"Account Number: {AccountNumber}, " + $"Account Holder:  {AccountHolder}, " + $"Balance:  {Balance:c}");
        }
    }
}
