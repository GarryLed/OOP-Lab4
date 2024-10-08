/*
 * Name: Garry Ledwith
 * Date: 07/10/24
 * Description:
 * Lab 4, Q7
Create a program named SchoolsDemo that allows a user to enter data about five School objects and then displays the School objects. 
The School class contains properties for the School name and number of students enrolled.

Amend the program so that schools can be displayed in order or enrolment. 
We have not covered this yet so you may need to do some research yourself!  Hint – use IComparable.  

  
*/
using System;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School[] schools = new School[5];

            // allow user to enter data about five school objects 

            for (int i = 0; i < schools.Length; i++)
            {
                Console.Write("Enter the name of the school: ");
                string name = Console.ReadLine();
                Console.Write("Enter number of students enrolled: ");
                int numOfStudentsEnrolled = int.Parse(Console.ReadLine());
                

                //cars[i] = new Car(name, brand, colour); // instantites a new Car object with 3 attributes at each iteration
                schools[i] = new School(name, numOfStudentsEnrolled);
            }

            // display shcool information 
            DisplaySchoolDetails(schools);


        } // end of main 
        static void DisplaySchoolDetails(params School[] schools)
        {
            Console.WriteLine("{0, -20}{1, -20}", "School Name", "Number of students enrolled");
            foreach (School school in schools)
            {
                Console.WriteLine("{0, -20}{1, -20}", school.SchoolName, school.NumberOfEnrolledStudents);
            }
        }
    }
}