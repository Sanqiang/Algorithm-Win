/*
            MultiThread.Semaphore.test();
*/

using System;

namespace Algorithm.MultiThread
{
    class Semaphore
    {
        System.Threading.Semaphore s1, s2;
        public Semaphore()
        {
            s1 = new System.Threading.Semaphore(1, 5);
            s2 = new System.Threading.Semaphore(1, 5);
            // <= 0 DENY >0 APPROVE
            // Release +１　WaitOne -1
            //OR x
            // == 0 APPROVE >0 DENY
            //RELEASE -1 WAITONE +1
        }

        public void first()
        {
            Console.WriteLine("First");
            s1.Release();
        }

        public void second()
        {
            s1.WaitOne();
            s1.WaitOne();
            Console.WriteLine("Second");
            s2.Release();
        }

        public void third()
        {
            s2.WaitOne();
            s2.WaitOne();
            Console.WriteLine("Third");

        }

        public void startnum(object obj)
        {
            int i = (int)obj;
            switch (i)
            {
                case 1:
                    first();
                    break;
                case 2:
                    second();
                    break;
                case 3:
                    third();
                    break;
                default:
                    break;
            }
        }

        public static void test()
        {
            Semaphore s = new Semaphore();
            System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(s.startnum));
            System.Threading.Thread t2 = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(s.startnum));
            System.Threading.Thread t3 = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(s.startnum));
            t1.Start(3);
            t2.Start(2);
            t3.Start(1);
        }
    }
}
