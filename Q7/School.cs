using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class School
    {

        /*
         * Create a program named SchoolsDemo that allows a user to enter data about five School objects and then displays the School objects. 
            The School class contains properties for the School name and number of students enrolled.

            Amend the program so that schools can be displayed in order or enrolment. 
            We have not covered this yet so you may need to do some research yourself!  Hint – use IComparable.
         * 
         */

        // properties 
        public string SchoolName { get; set; }
        public int NumberOfEnrolledStudents { get; set; }

        // parameterized contructor 
        public School(string name, int numOfEnrolledStudents) 
        {
            SchoolName = name;
            NumberOfEnrolledStudents = numOfEnrolledStudents;
        }
    }
}
