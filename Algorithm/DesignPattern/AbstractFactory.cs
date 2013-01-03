using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    abstract class AbstractFactory
    {
        public abstract AbstractCPU buildCPU();
        public abstract AbstractMemory buildMemory();
    }

    class MyFactory : AbstractFactory
    {
        public override AbstractCPU buildCPU()
        {
            return new I7();
        }

        public override AbstractMemory buildMemory()
        {
            return new M16G();
        }
    }

    abstract class AbstractCPU
    {
        public AbstractCPU()
        {
        }
    }

    class I7 : AbstractCPU
    {
        public I7()
        {
            Console.WriteLine("Create i7");
        }
    }
    class I5 : AbstractCPU
    {
        public I5()
        {
            Console.WriteLine("Create i5");
        }
    }

    abstract class AbstractMemory
    {
        public AbstractMemory()
        {
        }
    }

    class M16G : AbstractMemory
    {
        public M16G()
        {
            Console.WriteLine("Create 16g");
        }
    }

    class M8G : AbstractMemory
    {
        public M8G()
        {
            Console.WriteLine("Create 8g");
        }
    }
}
