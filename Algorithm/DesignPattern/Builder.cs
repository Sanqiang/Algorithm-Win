using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    abstract class AbstractBuilder
    {
        protected string _CPU, _Memory;
        public abstract void buildCPU();
        public abstract void buildMemory();
        public abstract Computer getComp();
    }

    class Builder : AbstractBuilder
    {

        public override void buildCPU()
        {
            this._CPU = "I7";
        }

        public override void buildMemory()
        {
            this._Memory = "16G";
        }


        public override Computer getComp()
        {
            return new Computer(_CPU, _Memory);
        }
    }

    class Computer
    {
        protected string _CPU, _Memory;
        public Computer(string CPU, string Memory)
        {
            this._CPU = CPU;
            this._Memory = Memory;
        }
    }

    class Manager
    {
        public Computer buildComp(Builder b)
        {
            b.buildCPU();
            b.buildMemory();
            return b.getComp();
        }
    }
}
