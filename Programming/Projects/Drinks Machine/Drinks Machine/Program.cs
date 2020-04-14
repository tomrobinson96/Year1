using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myOrderAmount = { 0, 0, 0, 0, 0, 0 };
            myOrderAmount[0]++;
            myOrderAmount[1]++;
            myOrderAmount[2]++;
            myOrderAmount[3]++;
            myOrderAmount[4]++;
            myOrderAmount[5]++;           
            
            string userReasponse1 = "";
            bool exitProgram1 = false;
            do
            {
                Console.WriteLine("Please Select tea or coffee");
                Console.WriteLine("A) Tea");
                Console.WriteLine("B) Coffee");
                Console.WriteLine("X) Exit Program");
                userReasponse1 = Console.ReadLine();

                switch (userReasponse1)
                { 
                    case "A":
                        Console.WriteLine("You have chosen to make Tea, Please selct from the following Options: ");

                        string userResponse = "";           

            do
            {
                //print menu                
                Console.WriteLine("A) Tea with Sugar and Milk");
                Console.WriteLine("B) Tea with Sugar only");
                Console.WriteLine("C) Tea with milk only");
                Console.WriteLine("X) Back to top menu");
                userResponse = Console.ReadLine();

                userResponse = userResponse.ToUpper(); // Makes it all upper case
                userResponse = userResponse.Trim(); // cuts off any spare spaces before or after the statement

                //process user response
                switch (userResponse)
                {

                    case "A":
                        Console.WriteLine("We will be making tea with sugar and milk");
                        Console.WriteLine("You have sold {0} tea (s) with milk and sugar    ", myOrderAmount[0] );
                        break;
                    case "B":
                        Console.WriteLine("we will be making tea with sugar only");
                        Console.WriteLine("You have sold {0} tea (s) with sugar", myOrderAmount[1]);
                        break;
                    case "C":
                        Console.WriteLine("we will be making tea with milk only");
                        Console.WriteLine("You have sold {0} tea (s) with milk", myOrderAmount[2] );
                        break;
                    case "X":
                        
                        exitProgram2 = true;
                        break;
                    default:
                        Console.WriteLine("please enter a valid statement");
                        break;
                        
                            
                        

                }
            } while (!exitProgram2);

            Console.ReadLine();

                        break;

                    case "B":
                        Console.WriteLine("You have chosen to make Coffee, Please selct from the following Options: ");

                         

                        string userResponse2 = "";
            

            do
            {
                //print menu

                
                Console.WriteLine("D) Coffee with Sugar and Milk");
                Console.WriteLine("E) Coffee with Sugar only");
                Console.WriteLine("F) Coffe with milk only");
                Console.WriteLine("X) Back to top menu");
                userResponse2 = Console.ReadLine();

                userResponse2 = userResponse2.ToUpper(); // Makes it all upper case
                userResponse2 = userResponse2.Trim(); // cuts off any spare spaces before or after the statement

                //process user response
                switch (userResponse2)


                {



                    case "D":
                        Console.WriteLine("We will be making Coffee with sugar and milk");
                        Console.WriteLine("You have sold {0} coffee (s) with milk and sugar    ", myOrderAmount[3] );
                        break;
                    case "E":
                        Console.WriteLine("we will be making Coffee with sugar only");
                        Console.WriteLine("You have sold {0} coffee (s) with sugar", myOrderAmount[4]);
                        break;
                    case "F":
                        Console.WriteLine("we will be making Coffee with milk only");
                        Console.WriteLine("You have sold {0} coffee (s) with milk", myOrderAmount[5]);
                        break;
                    case "X":
                        
                        exitProgram2 = true;
                        break;
                    default:
                        Console.WriteLine("please enter a valid statement");
                        break;
                        
                            
                        

                }
            } while (!exitProgram2);

            Console.ReadLine();
                        break;
                    case "X":
                        Console.ReadLine();
                        
                        break;

                         default:
                        Console.WriteLine("please enter a valid statement");
                        break;




                }
            } while (!exitProgram1);

            Console.ReadLine();


            


        }

        public static bool exitProgram2 { get; set; }
    }
}
