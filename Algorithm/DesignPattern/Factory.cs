using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    abstract class AbstractHeaterFactory
    {
        public abstract AbstractHeater getHeater();
    }

    class HeaterFactory : AbstractHeaterFactory
    {

        public override AbstractHeater getHeater()
        {
            return new Heater();
        }
    }

    abstract class AbstractHeater
    {
        public abstract void open();
        public abstract void close();
    }

    class Heater : AbstractHeater
    {

        public override void open()
        {
            Console.WriteLine("Open");
        }

        public override void close()
        {
            Console.WriteLine("Close");
        }
    }
}
