/*
 * Name: Garry Ledwith
 * Date: 07/10/24
 * Description:
 * Lab 4, Q1 and Q2
 * Q1
 Create a Car class with the following properties - 
Make, Model, Current Speed, Engine Size. Use long hand properties, with private attributes and getters and setters. 
In the program.cs file make use of this class by creating two objects and displaying details on the cars. 
  
Q2
Add the following methods to the car class

DisplayCarInfo – this should output the car information to the console
ToString – this should return a string which has car information which you should use in a Console.WriteLine statement
Accelerate – this should increase the speed by 10
Use a for loop to increase the car speed in increments of 10 up to 100.
*/

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create objects of the Car class 
            Car car1 = new Car("Opel", "Astra", 0, 1.2); // using the parameterized constructor 

            Car car2 = new Car(); // uisng default constructor  
            // using Set methods to set attributes 
            car2.Make = "Ford";
            car2.Model = "Focus";
            car2.CurrentSpeed = 0;
            car2.EngineSize = 1.6;

            // Q1 display details of car 
            Console.WriteLine("Q1");
            Console.WriteLine(car1);
            Console.WriteLine(car2);
            Console.WriteLine();

            // Q2 
            // Calling the DisplayCarInfo method on a car object 
            Console.WriteLine("Q2");
            car1.DisplayCarInfo();
            car2.DisplayCarInfo();

            // using a for loop to increment car speed upto 100 
            for (int i = 0; i < 10; i++) 
            {
                car2.Accelerate(); // calling the Accelerate method on the car2 object 
            }

            Console.WriteLine(car2);
        }
    }
}
