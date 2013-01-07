using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    class Prototype
    {
    }

    class ManagerX
    {
        People _p;
        Weapon _w;
        public ManagerX(People p, Weapon w)
        {
            this._p = p;
            this._w = w;
        }
    }

    abstract class People
    {
        public string name;
        public abstract void walk();
    }

    class Hypnus : People
    {
        public Hypnus()
        {
            this.name = "Hypnus";
        }

        public override void walk()
        {
            Console.WriteLine("Walk");
        }
    }

    abstract class Weapon
    {
        public abstract void kill();
    }

    class Gun : Weapon
    {

        public override void kill()
        {
            Console.WriteLine("Kill");
        }
    }
}
