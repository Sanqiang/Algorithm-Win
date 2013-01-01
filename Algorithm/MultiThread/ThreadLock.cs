
namespace Algorithm.MultiThread
{
    class ThreadLock
    {
        static System.Collections.Generic.List<int> arr = new System.Collections.Generic.List<int>();
        public static void test()
        {
            for (int i = 0; i < 100; i++)
            {
                arr.Add(i);
            }

            System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(removeItem));
            t1.Name = "GDI";
            t1.Start(null);
            System.Threading.Thread t2 = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(removeItem));
            t2.Name = "NOD";
            t2.Start(null);
        }
        static System.Threading.ReaderWriterLock rwl = new System.Threading.ReaderWriterLock();
        static object CodeLock = new object();     //LOCK the code with lock keyword or Moniter
        //[Synchronization(SynchronizationOption.Required)]   //SynchronizationAttribute from System.EnterpriseServices.dll (Synchronise the method)
        private static void removeItem(object o)
        {

            while (arr.Count > 0)
            {
                //lock (CodeLock)
                //{
                //System.Threading.Monitor.Enter(CodeLock);
                //System.Threading.Monitor.Wait(CodeLock);
                //System.Threading.Monitor.Pulse(CodeLock);
                //rwl.AcquireReaderLock(1000);
                System.Console.WriteLine(System.Threading.Thread.CurrentThread.Name + " get " + arr[0]);
                //rwl.ReleaseReaderLock();
                //rwl.AcquireWriterLock(1000);
                arr.RemoveAt(0);
                //rwl.ReleaseWriterLock();
                System.Threading.Thread.Sleep(1000);
                //System.Threading.Monitor.Exit(CodeLock);
                //}
            }

        }

        static void test2()
        {
            //System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(printX));

        }

        private static void printX()
        {
            
        }
    }
}
