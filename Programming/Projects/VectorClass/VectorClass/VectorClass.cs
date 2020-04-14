using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorClass
{
    class VectorClass
    {
        //public properties
        public int x { get; set; }
        public int y {get; set;}
        
        //constuctor - see usage in Main()- is called whenever 'new VectorClass (1, 2)' is present in code
        public VectorClass (int valueOne, int valueTwo)
            {
                this.x = valueOne;
                this.y = valueTwo;
                //this.o = valueThree;
            }
        public int AddThemTogether()
        {
            return this.x + this.y;
        }
        public int MultiplyThemTogether()
        {
            return this.x * this.y;
        }
        public int DotProduct()
        {
            return this.x * this.y * Math.Cos(numberAngle);
        }
    }
}
