using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    class Proxy
    {
    }

    interface IProxy
    {
        public void doSomething();
    }

    class LongDistanceProxy : IProxy
    {
        public void doSomething()
        {
            //Do something
        }
    }

    class ShortDistanceProxy : IProxy
    {
        public void doSomething()
        {
            //Do something
        }
    }
}
