/*
 * Name: Garry Ledwith
 * Date: 07/10/24
 * Description:
 * Lab 4, Q6
Create an application named LunchDemo that declares several Lunch objects and includes a display
method to which you can pass different numbers of Lunch objects in successive method calls.
This should use the params keyword.  Not something we have seen so some research is needed. 
The Lunch class contains auto-implemented properties for an entree, side dish, and drink.  

  
*/
namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize new Lunch objects 
           
            Lunch lunch1 = new Lunch();
            Lunch lunch2 = new Lunch();
            Lunch lunch3 = new Lunch();
            Lunch lunch4 = new Lunch();
            Lunch lunch5 = new Lunch();

            lunch1.Entree = "hamburger";
            lunch1.SideDish = "fries";
            lunch1.Drink = "cola";

            lunch2.Entree = "hot dog";
            lunch2.SideDish = "chips";
            lunch2.Drink = "lemonade";

            lunch3.Entree = "pizza";
            lunch3.SideDish = "salad";
            lunch3.Drink = "ice tea";

            lunch4.Entree = "tuna sandwhich";
            lunch4.SideDish = "fruit cup";
            lunch4.Drink = "water";

            lunch5.Entree = "peanut butter sanswhich";
            lunch5.SideDish = "cookie";
            lunch5.Drink = "milk";

            DisplayLunchDetails(lunch1, lunch2 , lunch3);

        } // end of main 
          // Display Method 
        static void DisplayLunchDetails(params Lunch[] lunches)
        {
            Console.WriteLine("{0, -15}{1, -15}{2, -15}", "Entree", "Side", "Drink");
            foreach (Lunch lunch in lunches) 
            {
                Console.WriteLine("{0, -15}{1, -15}{2, -15}", lunch.Entree, lunch.SideDish, lunch.Drink);
            }
        }
    }
}