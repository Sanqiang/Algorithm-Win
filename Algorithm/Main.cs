using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Algorithm.TreeAndGraph;
using Algorithm.LinkedList;
using System.Net;


namespace Algorithm
{
    class MainClass
    {
        //[MethodImpl(MethodImplOptions.InternalCall)]
        public static void Main(string[] args)
        {
            LinkedNode node = LinkedNode.getInst();
            var list = new Leetcode.ReverseLinkedListII().reverseBetween(node,2,4);

            Console.WriteLine("I am done");
            Console.ReadLine();
        }

    }


}
