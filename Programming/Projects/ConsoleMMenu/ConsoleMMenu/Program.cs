using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse = "";
            bool exitProgram = false;
            do
            {
                //print menu

                Console.WriteLine("program menu : please select one of the following options");
                Console.WriteLine("M) Distance in miles");
                Console.WriteLine("K) Distance in kilometeres");
                Console.WriteLine("A) Distance in Austronomical Units");
                Console.WriteLine("X) Exit Program");
                userResponse = Console.ReadLine();

                userResponse = userResponse.ToUpper(); // Makes it all upper case
                userResponse = userResponse.Trim(); // cuts off any spare spaces before or after the statement

                //process user response
                switch (userResponse)
                {
                    case "M":
                        Console.WriteLine("We will be working in miles");
                        break;
                    case "K":
                        Console.WriteLine("we will be working in kilometers");
                        break;
                    case "A":
                        Console.WriteLine("we will be working in AU");
                        break;
                    case "X":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("please enter a valid statement");
                        break;

                } 
            } while (!exitProgram);

            Console.ReadLine();

        }
    }
}
