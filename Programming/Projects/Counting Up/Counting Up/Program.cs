using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Up
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable to store our total number
            float total = 6.3f;
            Console.WriteLine("total currently {0}", total);
            total = total + 2;
            Console.WriteLine("total now {0}", total);
            total = total + 1;
            Console.WriteLine("total changed to : {0}", total);
            total += 3;
            Console.WriteLine("total finally: {0}", total);
            Console.ReadLine();


        }
    }
}
