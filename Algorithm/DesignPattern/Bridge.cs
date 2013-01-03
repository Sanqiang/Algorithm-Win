using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    class Bridge
    {
    }

    abstract class Robot
    {
        Progressor _fuel;
        public Robot(Progressor fuel)
        {
            this._fuel = fuel;
        }

        public abstract void move();
    }

    class RobotA : Robot
    {

        public override void move()
        {
            Console.WriteLine("Move fast");
        }
    }

    class RobotB : Robot
    {

        public override void move()
        {
            Console.WriteLine("Move slow");
        }
    }

    abstract class Progressor
    {
        string name;
    }

    class K12 : Progressor { }
    class B5 : Progressor { }
}
