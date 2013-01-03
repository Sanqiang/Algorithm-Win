using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    class Strategy
    {
    }

    public interface IStrategy
    {
        void OnTheWay();
    }

    public class WalkStrategy : IStrategy
    {
        public void OnTheWay()
        {
            Console.WriteLine("Walk on the road");
        }
    }

    public class RideBickStragtegy : IStrategy
    {
        public void OnTheWay()
        {
            Console.WriteLine("Ride the bicycle on the road");
        }
    }

    public class CarStragtegy : IStrategy
    {
        public void OnTheWay()
        {
            Console.WriteLine("Drive the car on the road");
        }
    }
}
