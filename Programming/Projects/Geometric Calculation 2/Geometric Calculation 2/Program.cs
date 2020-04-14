using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Calculation_2
{
    class Program
    {
        static void Main(string[] args)

        {
            string userResponse = "";
            bool exitProgram = false;
            do
            { 
               Console.WriteLine("program menu : please select one of the following options");
                Console.WriteLine("A) Working out Rectangle volume:");
                Console.WriteLine("B) Working out if your triangle is right-angled");
                Console.WriteLine("X) Exit Program");
                userResponse = Console.ReadLine();

                userResponse = userResponse.ToUpper();
                userResponse = userResponse.Trim();

                switch (userResponse)
                { 
                    case "A":

            string height;
            string width;
            string length;


            Console.Write("please enter rectangle height: ");
            height = Console.ReadLine();
            Console.Write("please enter rectangle width: ");
            width = Console.ReadLine();
            Console.Write("please enter rectangle length: ");
            length = Console.ReadLine();

            int number = Convert.ToInt32(height);
            int wNumber = Convert.ToInt32(width);
            int lNumber = Convert.ToInt32(length);

            int volumeOfRectanglularbox = number * wNumber * lNumber;

            Console.Write("The volume of your box is: {0}", volumeOfRectanglularbox);

            Console.ReadLine();
                        break;

                    

            {
                string sideA;
                string sideB;
                string sideC;

                Console.Write("please enter a value for side A: ");
                sideA = Console.ReadLine();
                Console.Write("please enter a value for side B: ");
                sideB = Console.ReadLine();
                Console.Write("please enter a value for side C: ");
                sideC = Console.ReadLine();

                int numberA = Convert.ToInt32(sideA);
                int numberB = Convert.ToInt32(sideB);
                int numberC = Convert.ToInt32(sideC);

                int numberASqrd = numberA * numberA;
                int numberBSqrd = numberB * numberB;
                int numberCSqrd = numberC * numberC;
                int userSide;

                if (numberC > numberB && numberC > numberA)
                {
                    userSide =  numberBSqrd + numberASqrd;
                    Console.WriteLine("your value for side C squared is: {0}", userSide);
                    Console.ReadLine();
                    Console.WriteLine("your value for side C squared should be: {0}", numberCSqrd);
                    Console.ReadLine();
                    

                }
                else Console.WriteLine("side C must be the greatest, please re-enter your values");
                Console.ReadLine();

                do
                {
                    Console.Write("please enter a value for side A: ");
                    sideA = Console.ReadLine();
                    Console.Write("please enter a value for side B: ");
                    sideB = Console.ReadLine();
                    Console.Write("please enter a value for side C: ");
                    sideC = Console.ReadLine();
                }
                while (numberC > numberB && numberC > numberA);

                Console.ReadLine();

                break;
                
                  
                } 
            } while (!exitProgram);

            Console.ReadLine();
            }
            };
    }
}
                


            

       

