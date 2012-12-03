/*
             LinkedList.LinkedNode ln1 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode ln2 = new LinkedList.LinkedNode(9);
            LinkedList.LinkedNode ln3 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode ln4 = new LinkedList.LinkedNode(2);
            ln1.Next = ln2; ln2.Next = ln3; ln3.Next = ln4;
            LinkedList.LinkedNode lo1 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode lo2 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode lo3 = new LinkedList.LinkedNode(9);
            lo1.Next = lo2; lo2.Next = lo3;
            LinkedList.LinkedNode ln10 = new LinkedList.LinkedNode(10);
            ln4.Next = ln10; lo3.Next = ln10;

            Console.WriteLine(Microsoft.Q62.findCommonNode(ln1, lo1).Data);
 */ 
namespace Algorithm.Microsoft
{
    class Q62
    {
        public static LinkedList.LinkedNode findCommonNode(LinkedList.LinkedNode ln1, LinkedList.LinkedNode ln2)
        {
            LinkedList.LinkedNode Runner1 = ln1;
            LinkedList.LinkedNode Runner2 = ln2;

            int length1 = ln1.getLength();
            int length2 = ln2.getLength();
            if (length1>length2)
            {
                for (int i = 0; i < length1 - length2; i++)
                {
                    Runner1 = Runner1.Next;
                }
            }
            else
            {
                for (int i = 0; i < length2 - length1; i++)
                {
                    Runner2 = Runner2.Next;
                }
            }


            while (Runner1 != Runner2)
            {
                Runner1 = Runner1.Next;
                Runner2 = Runner2.Next;
            }
            return Runner1;
        }
    }
}
