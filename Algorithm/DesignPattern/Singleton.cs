using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    class Singleton
    {
        private static volatile Singleton _instance = null;
        private static object SysRoot = new object();
        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get{
                if (_instance == null)
                {
                    lock(SysRoot)
                    {
                        _instance = new Singleton();
                    }
                }
                return _instance;
            }
        }
    }
}
