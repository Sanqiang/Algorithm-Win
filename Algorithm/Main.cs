using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Algorithm.TreeAndGraph;
using Algorithm.LinkedList;


namespace Algorithm
{
    class MainClass
    {
        //[MethodImpl(MethodImplOptions.InternalCall)]
        public static void Main(string[] args)
        {
            MultiThread.ProducerAndConsumer.test_eventhandler();
            Console.WriteLine("I am done");
            Console.ReadLine();
        }

    }


}
