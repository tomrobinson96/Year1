using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Sales
{
    class Program
    {
        const int DISCOUNT_AGE = 18;
        const int TICKETS_REMAINING_CUTOFF = 5;
        static void Main(string[] args)
        {
            bool backtop = true;
            string age;
            float ageNum;
            float ticketsRemaining = 5;
            Boolean nusCard = false;
            string nuss = "";
            Boolean restart;
            string startAgain;

            while (backtop)
           { 
            Console.WriteLine("Tickets remaining: " + ticketsRemaining);
            Console.WriteLine("How old are you?");
            age = Console.ReadLine();
            ageNum = Single.Parse(age);

            Console.WriteLine("If you have an NUS card ? (True/False)");
            nuss = Console.ReadLine();
            nusCard = Convert.ToBoolean(nuss);

            if (nusCard == true)
                { 
                    Console.WriteLine("you qualify for discounted price");
                    Console.ReadLine();
                }

            else
            {
                if (ageNum < DISCOUNT_AGE)
                {
                    Console.WriteLine("You are young enough to get a dicounted price");
                    Console.ReadLine();
                    
                    Console.WriteLine("you get a discount");
                    Console.ReadLine();
                }
                else
                    {
                        Console.WriteLine("being {0} or older, you don't get a discount.", DISCOUNT_AGE);
                        Console.ReadLine();
                        Console.WriteLine("you must pay full price");
                        Console.ReadLine();

                    }                
                
            }

            if (ticketsRemaining > 0)
                {

                    Console.WriteLine("Ticket Sold");
                    ticketsRemaining--;
                    Console.WriteLine(ticketsRemaining);
                    
                }
                else
                    {
                        Console.WriteLine("No tickets remaining");
                    }

                Console.WriteLine("Do you want to buy another ticket?");
                startAgain = Console.ReadLine();
                restart = Convert.ToBoolean(startAgain);

                if (restart == false)
                    { 
                        break;
                    }
           }
           backtop = false;

            

            }
        }
    }
