/*
            StackAndQueue.Stack s = new StackAndQueue.Stack();
            s.push(1); s.push(3); s.push(2); s.push(5); s.push(4);
            //StackAndQueue.CC3_6.SortStack(s);
            //Console.WriteLine(s.toString());
            Console.WriteLine(StackAndQueue.CC3_6.SortStackV5(s).toString());
 */
namespace Algorithm.StackAndQueue
{
    class CC3_6
    {
        public static void SortStack(Stack s)
        {
            Stack helper = new Stack();

            helper.push(s.pop());
            while (true)
            {
                if (helper.peek() < s.peek())
                {
                    helper.push(s.pop());
                }
                if (s.getSize() == 0)
                {
                    break;
                }
                double loop = s.pop();
                while (loop < helper.peek())
                {
                    s.push(helper.pop());
                }
                helper.push(loop);
            }

            while (helper.getSize() != 0)
            {
                s.push(helper.pop());
            }
        }

        public static Stack SortStackV5(Stack s)
        {
            Stack n = new Stack();
            while (s.getSize() != 0)
            {
                double tmp = s.pop();
                while (n.getSize()!=0&&n.peek()<tmp)
                {
                    s.push(n.pop());
                }
                n.push(tmp);
            }
            return n;
        }
    }
}
