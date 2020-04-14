using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class TemperatureClass
    {
        public TemperatureClass()
        {
            // as soon as an object is created without any parameters,
            //this constructor method will run and attempt to crash
            // your program with a NotSupportedException error.
            throw new NotSupportedException();
        }
        public TemperatureClass(double c)
        {
            //this.celcuisTemp1 = c;
        }
    }
}