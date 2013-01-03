using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    class Flyweight
    {
        private void memeory()
        {
            Console.WriteLine(GC.GetTotalMemory(false));
        }
    }

    class Model
    {
        static Dictionary<int, Model> dic = new Dictionary<int, Model>();

        string _name;
        long _id;
        public Model getInstance(int id, string name)
        {
            Model m = null;
            if (dic[id] != null)
            {
                m = dic[id];
            }
            else
            {
                m = new Model();
                m._id = id;
                m._name = name;
            }
            return m;
        }
    }
}
