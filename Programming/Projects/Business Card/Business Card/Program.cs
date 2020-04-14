using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string Number;
            string university;
            string message;
            string DOB;
            Console.WriteLine("please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("please enter your Number");
            Number = Console.ReadLine();
            Console.WriteLine("please enter your university");
            university = Console.ReadLine();
            Console.WriteLine("please enter your Date of Birth");
            DOB = Console.ReadLine();
            message = "welcome.. " + name + ", your number is " + Number + ", you study at " + university + ", Your Date of Birth is " + DOB;
            Console.WriteLine(message);
                Console.ReadLine();

                    
        }
    }
}
