using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop
{
    abstract class Storage
    {
        public abstract void SaveToFile(System.IO.StreamWriter dataFileOut);
    }
}
