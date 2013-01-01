using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * MultiThread.ProducerAndConsumer.test();
 */
namespace Algorithm.MultiThread
{
    class ProducerAndConsumer
    {
        public int Food = 0;
        const int LIMIT = 5;

        private object SysRoot = new object();

        void produce()
        {
            while (true)
            {
                try
                {
                    System.Threading.Monitor.Enter(SysRoot);
                    if (Food == LIMIT)
                    {
                        System.Threading.Monitor.Pulse(SysRoot);
                        System.Threading.Monitor.Wait(SysRoot);
                    }
                    else
                    {
                        ++Food;
                        Console.WriteLine("Producer create One, Current:" + Food);

                        System.Threading.Monitor.Pulse(SysRoot);
                        System.Threading.Monitor.Wait(SysRoot);
                    }
                }
                catch (Exception e)
                {
                }
                finally
                {
                    System.Threading.Monitor.Exit(SysRoot);
                } Sleep();
            }

        }

        void consumer()
        {
            while (true)
            {
                try
                {
                    System.Threading.Monitor.Enter(SysRoot);
                    if (Food == 0)
                    {
                        System.Threading.Monitor.Pulse(SysRoot);
                        System.Threading.Monitor.Wait(SysRoot);
                    }
                    else
                    {
                        --Food;
                        Console.WriteLine("Consumer eat One, Current:" + Food);
                        System.Threading.Monitor.Pulse(SysRoot);
                        System.Threading.Monitor.Wait(SysRoot);
                    }
                }
                catch (Exception e)
                {
                }
                finally
                {
                    System.Threading.Monitor.Exit(SysRoot);
                } Sleep();
            }
        }

        void Sleep()
        {
            System.Threading.Thread.Sleep(new Random().Next(3) * 1000);
        }

        public static void test()
        {
            ProducerAndConsumer pac = new ProducerAndConsumer();
            System.Threading.Thread producer = new System.Threading.Thread(new System.Threading.ThreadStart(pac.produce));
            System.Threading.Thread consumer = new System.Threading.Thread(new System.Threading.ThreadStart(pac.consumer));
            producer.Start();
            consumer.Start();
            System.Threading.Thread producer1 = new System.Threading.Thread(new System.Threading.ThreadStart(pac.produce));
            System.Threading.Thread consumer1 = new System.Threading.Thread(new System.Threading.ThreadStart(pac.consumer));
            producer1.Start();
            consumer1.Start();
            System.Threading.Thread producer2 = new System.Threading.Thread(new System.Threading.ThreadStart(pac.produce));
            System.Threading.Thread consumer2 = new System.Threading.Thread(new System.Threading.ThreadStart(pac.consumer));
            producer2.Start();
            consumer2.Start();
        }

        //2
        const int NUM_CONSUMER = 10;
        private System.Threading.EventWaitHandle event_producer = new System.Threading.EventWaitHandle(false, System.Threading.EventResetMode.AutoReset); //No reset
        private System.Threading.EventWaitHandle[] event_consumers = new System.Threading.EventWaitHandle[NUM_CONSUMER];

        public ProducerAndConsumer()
        {
            for (int i = 0; i < NUM_CONSUMER; ++i)
                event_consumers[i] = new System.Threading.EventWaitHandle(false, System.Threading.EventResetMode.AutoReset);
        }
        int Meat = 0;

        public void method_producer()
        {
            int need = NUM_CONSUMER - Meat;
            Meat += need;
            if (need > 0)
            {
                Console.WriteLine("Add " + need + " Meat!!!");
            }
            event_producer.Set();
            System.Threading.EventWaitHandle.WaitAll(event_consumers);
            Sleep();
        }

        public void method_comsumer(object i)
        {
            while (Meat > 0)
            {
                int index = (int)i;
                if (Meat > 0)
                {
                    --Meat;
                    System.Threading.EventWaitHandle.SignalAndWait(event_consumers[index], event_producer);
                    Console.WriteLine("EAT,  Remaing:" + Meat);
                }
                System.Threading.EventWaitHandle.SignalAndWait(event_producer, event_consumers[index]);
                Sleep();
            }
            
        }

        public static void test_eventhandler()
        {
            ProducerAndConsumer pac = new ProducerAndConsumer();
            System.Threading.Thread producer = new System.Threading.Thread(new System.Threading.ThreadStart(pac.method_producer));
            producer.Start();
            for (int i = 0; i < 3; i++)
            {
                System.Threading.Thread consumer = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(pac.method_comsumer));
                consumer.Start(i);
            }
        }
    }
}
