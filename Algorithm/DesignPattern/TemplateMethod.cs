using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    class TemplateMethod
    {
    }

    abstract class AbstractMissle
    {
        protected abstract void target();
        protected abstract void bomb();

        public void attack()
        {
            target();
            bomb();
        }
    }

    class AtomicBomb:AbstractMissle
    {

        protected override void target()
        {
            Console.WriteLine("Target");
        }

        protected override void bomb()
        {
            Console.WriteLine("Bomb");
        }
    }
}
