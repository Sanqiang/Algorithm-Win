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

            double[,] matrix =  {
            {15, 20, 70, 85},
            {20, 35, 80, 95},
            {30, 55, 95, 105},
            {40, 80, 120, 120}
        };

            Console.WriteLine(SortAndSearch.CC9_6.SearchOnMatrixMyV5(matrix, 20));



            //MultiThread.ProducerAndConsumer.test_eventhandler();
            Console.WriteLine("I am done");
            Console.ReadLine();
        }

    }


}
