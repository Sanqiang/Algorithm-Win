using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Algorithm.MultiThread
{
    class Volative
    {
        public volatile List<int> arr;
        public Volative()
        {
            arr = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                arr.Add(i + 1);
            }
        }

        public void get()
        {

            while (arr.Count != 0)
            {
                lock (this)
                {
                    if (arr.Count != 0)
                    {
                        System.Console.WriteLine(System.Threading.Thread.CurrentThread.Name + " get " + arr[0]);
                        arr.RemoveAt(0);
                    }
                }
            }
        }

        public void test()
        {
            System.Threading.Thread GDI = new System.Threading.Thread(new System.Threading.ThreadStart(get));
            System.Threading.Thread NOD = new System.Threading.Thread(new System.Threading.ThreadStart(get));
            GDI.Name = "GDI";
            NOD.Name = "NOD";
            GDI.Start();
            NOD.Start();
        }
    }
}
