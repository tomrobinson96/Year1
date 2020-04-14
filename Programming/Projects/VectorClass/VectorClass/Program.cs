using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorClass
{
    class MainClass
    {
        static void Main(string[] args)
        {
            float numberAngle;
            string angle;
            //crete two objects based on 'VectorClass' and to give their 'x' and 'y' properties some intial values
            //by making use of the Vector Class constructor method
            VectorClass vectorOne = new VectorClass(1, 2);
            VectorClass vectorTwo = new VectorClass(3, 4);
           // VectorClass vectorThree = new VectorClass (
            Console.WriteLine(" Please enter the value of the angle");
            angle = Console.ReadLine();
            numberAngle = Single.Parse(angle);
            Console.WriteLine(" angle currently.... {0}", numberAngle);
            Console.ReadLine();

            Console.WriteLine(" vectorOne.x = {0} \n vectorOne.y = {1}", vectorOne.x, vectorOne.y);
            Console.WriteLine(" vectorTwo.x = {0} \n vectorTwo.y = {1}", vectorTwo.x, vectorTwo.y);
            Console.WriteLine();

            Console.WriteLine(" vecotrOne.AddThemTogether() = {0}", vectorOne.AddThemTogether());
            Console.WriteLine(" vecotrTwo.AddThemTogether() = {0}", vectorTwo.AddThemTogether());
            Console.WriteLine();

            Console.WriteLine(" vecotrOne.MultiplyThemTogether() = {0}", vectorOne.MultiplyThemTogether());
            Console.WriteLine(" vecotrTwo.MultiplyThemTogether() = {0}", vectorTwo.MultiplyThemTogether());
            Console.ReadLine();


        }
    }
}
