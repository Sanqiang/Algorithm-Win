/*
             System.Collections.Generic.Stack<int> s = new System.Collections.Generic.Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Microsoft.Q66.reverseStack(s);
            while (s.Count != 0)
            {
                Console.WriteLine(s.Pop());
            }
 */
namespace Algorithm.Microsoft
{
    class Q66
    {
        public static void reverseStack(System.Collections.Generic.Stack<int> s)
        {
            if (s.Count != 0)
            {
                int data = s.Pop();
                reverseStack(s);
                addStackToBack(s, data);
            }
        }

        private static void addStackToBack(System.Collections.Generic.Stack<int> s, int m)
        {
            if (s.Count == 0)
            {
                s.Push(m);
            }
            else
            {
                int data = s.Pop();
                addStackToBack(s, m);
                s.Push(data);
            }
        }
    }
}