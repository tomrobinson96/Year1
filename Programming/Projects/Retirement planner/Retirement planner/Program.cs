using System;

namespace Retirement_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputAge;
            int age;
            int oldAge = 65;
            int difference;

            Console.WriteLine("Please enter your age");
            inputAge = Console.ReadLine();

            /* WE need to call a method to convert data types as we cant subtract a number from string
             * Convert, like console, is a library of functions within the system library
             * and this is a different type of comment syntax*/

            age = Convert.ToInt32(inputAge);

            // with these numbers tou can do maths
            
            difference = oldAge - age;

            // we could have built the message to show the user ourselves. Or we could use this syntax
            
            if ( age < oldAge)
            Console.WriteLine("in {0} years you will be 65 years old", difference);
            else
                Console.WriteLine("you are old enough to retire");
 
            Console.ReadLine();

        }
    }
}
