using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string message;
            string course;
            Console.WriteLine("Please enter your name");
            // Here we use "readline" to put string data into a variable
            name = Console.ReadLine();
            Console.WriteLine("please enter your course");
            course = Console.ReadLine();
            //construct a welcome message
            message = "Welcome..." + name + " to " + "Anglia Ruskin's " + course + " course";
            // write the message to the console
            Console.WriteLine(message);
            //Here we use readline to just pause the program
            Console.ReadLine();
        }
    }
}

