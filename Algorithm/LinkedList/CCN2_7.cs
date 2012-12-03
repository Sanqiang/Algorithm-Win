/*
             LinkedList.LinkedNode ln1 = new LinkedList.LinkedNode(1);
            LinkedList.LinkedNode ln2 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode ln3 = new LinkedList.LinkedNode(3);
            LinkedList.LinkedNode ln4 = new LinkedList.LinkedNode(3);
            LinkedList.LinkedNode ln5 = new LinkedList.LinkedNode(2);
            LinkedList.LinkedNode ln6 = new LinkedList.LinkedNode(1);
            ln1.Next = ln2; ln2.Next = ln3; ln3.Next = ln4; ln4.Next = ln5; //ln5.Next = ln6;
            Console.WriteLine(LinkedList.CCN2_7.verifyPalindrome(ln1));
 */ 
namespace Algorithm.LinkedList
{
    class CCN2_7
    {
        public static bool verifyPalindrome(LinkedNode head)
        {
            int length = 0;
            LinkedNode loop = head;
            while (loop != null)
            {
                loop = loop.Next;
                length++;
            }

            Result r = verifyPalindrome(head, length);


            return r.quilify;
        }

        private static Result verifyPalindrome(LinkedNode head, int length)
        {
            if (length == 2)
            {
                Result r = new Result(head.Next.Next, head.Data == head.Next.Data);
                return r;
            }
            else if (length == 1)
            {
                Result r = new Result(head.Next, true);
                return r;
            }
            else if (length == 0)
            {
                return new Result(null, true);
            }

            Result result = verifyPalindrome(head.Next, length - 2);

            if (result == null)
            {
                return result;
            }
            else
            {
                result.quilify = result.node.Data == head.Data;
                result.node = result.node.Next;
                return result;

            }
        }

        class Result
        {
            public LinkedNode node;
            public bool quilify;
            public Result(LinkedNode node, bool qualify)
            {
                this.node = node;
                this.quilify = qualify;
            }
            public Result(){}

        }

        public static bool verifyPalindromeIterate(LinkedNode head)
        {
            System.Collections.Generic.Stack<double> stack = new System.Collections.Generic.Stack<double>();
            LinkedNode SlowRunner = head;
            LinkedNode FastRunner = head;
            while (FastRunner != null && FastRunner.Next != null)
            {
                stack.Push(SlowRunner.Data);
                FastRunner = FastRunner.Next.Next;
                SlowRunner = SlowRunner.Next;
            }
            SlowRunner = SlowRunner.Next;
            while (SlowRunner!=null)
            {
                if (stack.Pop() == SlowRunner.Data)
                {
                    SlowRunner = SlowRunner.Next;
                }
                else
                {
                    return false;
                } 
            }
            return true;
        }
    }
}
