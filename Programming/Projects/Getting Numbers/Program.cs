using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable to hold number
            float numberFromUser = 0f;
            //string to hold text from user
            string userinput = "";

            Console.WriteLine("please enter a number between 1 and 10. then press Enter.");
            userinput = Console.ReadLine();

            //convert input string into an int
            numberFromUser = Single.Parse(userinput);

            //Add onle to the number, to prove we can
            numberFromUser++;
            Console.WriteLine("Result plus one is : {0}", numberFromUser);

            Console.ReadLine();

        }
    }
}
