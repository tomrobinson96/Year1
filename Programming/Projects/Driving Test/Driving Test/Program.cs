using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //this program will ask the user their age and tell them if they are able to take the UK driving test
            //Variable to store the user input
            string userInput;
            int userAge;
            int testAge;
            int yearsRemaining;

            testAge = 18;

            //Get user's age
            Console.WriteLine("please enter your current age");
            userInput = Console.ReadLine();
            userAge = Int32.Parse(userInput);

            //select which message to show
            //is the user old enough?
            if (userAge >= testAge)
                Console.WriteLine(" you are old enough");
            else
            {
                yearsRemaining = (testAge - userAge);
                Console.WriteLine(" you aren't old enough you may take the test in " + yearsRemaining + " years");
            }

            Console.ReadLine();

        }
    }
}
