/*
            MultiThread.StartThread.test();
            MultiThread.StartThread.test2(); 
 */
namespace Algorithm.MultiThread
{
    class StartThread
    {
        public static void test()
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(printTime));
            t.Start();
        }

        private static void printTime()
        {
            while (true)
            {
                System.Console.WriteLine("Current Time:" + System.DateTime.Now);
                System.Threading.Thread.Sleep(1000);
            }
        }

        public static void test2()
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(printTime2));
            t.Name = "TEST2";
            t.Start(1000);
        }

        private static void printTime2(object c)
        {
            int interval = 10;
            int.TryParse(c.ToString(), out interval);
            while (true)
            {
                System.Console.WriteLine("Current Time:" + System.DateTime.Now + " " + System.Threading.Thread.CurrentThread.Name);
                System.Threading.Thread.Sleep(interval);
            }
        }
    }
}
