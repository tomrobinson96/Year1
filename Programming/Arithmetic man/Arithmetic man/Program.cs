using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_man
{
    class Program
    {
        static void Main()
        {
            int [] values = new int[6];
            for (int i=0; i<6; i = i+1) ;
            {
                values [i] = readInt ( "Value : ", 0,20);
            }
        }
    }
}
