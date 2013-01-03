using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    class Facade
    {
        Face face;
        public void smell() { }
    }

    class Face
    {
        Eye left, right;
        Nose nose;
    }

    class Nose { }
    class Eye { }
}
