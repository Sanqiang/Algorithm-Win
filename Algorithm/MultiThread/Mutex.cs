using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *             MultiThread.Mutex.test();
 */
namespace Algorithm.MultiThread
{
    class Mutex
    {
        System.Threading.Mutex mutex, single;
        bool createdNew, singleFlag;
        public Mutex()
        {
            mutex = new System.Threading.Mutex(false, @"Gloabal/tmp2", out createdNew);
            single = new System.Threading.Mutex(true, @"ZHAOSANQIANG", out singleFlag);
        }

        public void One()
        {
            mutex.WaitOne();

            Console.WriteLine(System.Threading.Thread.CurrentThread.Name + " CreateNew:" + createdNew);

            mutex.ReleaseMutex();
        }

        public void Singlton()
        {
            try
            {
                if (singleFlag)
                {
                    Console.WriteLine("Single oNE");
                }
                else
                {
                    Console.WriteLine("Only oNE CAN RUN!!!");
                    return;
                }
            }
            finally
            {
                if (singleFlag)
                {
                    single.ReleaseMutex();
                }
                single.Close();
                single = null;
            }
        }

        public static void test()
        {
            Mutex m = new Mutex();
            for (int i = 0; i < 100; i++)
            {

                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(m.One));
                t.Name = i.ToString();
                t.Start();
                System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(m.Singlton));
                t1.Name = i.ToString();
                //t1.Start();


            }
        }
    }
}
