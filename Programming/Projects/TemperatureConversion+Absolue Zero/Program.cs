using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse = "";
            bool exitProgram = false;
            do
            {
                string userInput1;
                string userInput2;
                string userInput3;
                string userInput4;

                double celciusTemp1;
                double celciusTemp2;
                double farenheitTemp;
                double farenheitTemp2;
                double newCelcuis;
                double newFarenheit;
                double newCelcuis2;
                double newFarenheit2;
                //print menu

                Console.WriteLine("program menu : please select one of the following options");
                Console.WriteLine("A) Celsius to Farenheit");
                Console.WriteLine("B) Farenheit to Celsius");
                Console.WriteLine("C) Celsius to Kelvin");
                Console.WriteLine("D) Farenheit to Kelvin");
                Console.WriteLine("X) Exit Program");
                userResponse = Console.ReadLine();

                userResponse = userResponse.ToUpper(); // Makes it all upper case
                userResponse = userResponse.Trim(); // cuts off any spare spaces before or after the statement

                //process user response
                switch (userResponse)
                {
                    case "A":
                        Console.WriteLine("We will be converting celcuis to farenheit");
                        Console.WriteLine("Please enter the temperature in Celuis....");
                        userInput1= Console.ReadLine();
                        celciusTemp1 = Convert.ToInt32(userInput1);
                        Console.WriteLine("Current temperature is {0} Celcuis",celciusTemp1);
                        newCelcuis = celciusTemp1 *  9 / 5 + 32;
                        Console.WriteLine("This is {0} in Farenheit",newCelcuis);
                        Console.ReadLine(); 
                        Console.WriteLine("Please press enter to return to the menu");
                        Console.ReadLine();                        
                        break;
                    case "B":
                        Console.WriteLine("we will be Farenheit to Celcius");
                        Console.WriteLine("Please enter the temperature in Farenheit....");
                        userInput2= Console.ReadLine();
                        farenheitTemp = Convert.ToInt32(userInput2);
                        Console.WriteLine("Current temperature is {0} farenheit", farenheitTemp);
                        newFarenheit = farenheitTemp - 32 * 5 / 9;
                        Console.WriteLine("This is {0} in Celcuis", newFarenheit);
                         Console.ReadLine(); 
                        Console.WriteLine("Please press enter to return to the menu");
                        Console.ReadLine();
                        break;
                    case "C":
                        Console.WriteLine("we will be converting Celsuis to KElvin");
                        Console.WriteLine("Please enter the temperature in Celuis....");
                        userInput3= Console.ReadLine();
                        celciusTemp2 = Convert.ToInt32(userInput3);
                        Console.WriteLine("Current temperature is {0} Celcuis",celciusTemp2);
                        newCelcuis2 = celciusTemp2 + 274.15;
                        Console.WriteLine("This is {0} in Kelvin", newCelcuis2);
                         Console.ReadLine(); 
                        Console.WriteLine("Please press enter to return to the menu");
                        Console.ReadLine();
                        break;
                    case "D":
                        Console.WriteLine("we will be converting Farenneit to Kelvin");
                        Console.WriteLine("Please enter the temperature in Farenheit....");
                        userInput4 = Console.ReadLine();
                        farenheitTemp2 = Convert.ToInt32(userInput4);
                        Console.WriteLine("Current temperature is {0} Farenheit",farenheitTemp2);
                        newFarenheit2 = farenheitTemp2 - 32 / 1.8 + 274.15;
                        Console.WriteLine("This is {0} in Kelvin", newFarenheit2);
                         Console.ReadLine(); 
                        Console.WriteLine("Please press enter to return to the menu");
                        Console.ReadLine();

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