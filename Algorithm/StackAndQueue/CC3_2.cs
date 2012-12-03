/*
             StackAndQueue.CC3_2.Stack s = new StackAndQueue.CC3_2.Stack();
            s.push(5); s.push(9); s.push(4); s.push(3); s.push(2); s.push(6); s.push(1);
            Console.WriteLine(s.min());
            Console.WriteLine(s.pop() + " " + s.min());
            Console.WriteLine(s.pop() + " " + s.min());
            Console.WriteLine(s.pop() + " " + s.min());
            Console.WriteLine(s.pop() + " " + s.min());
            Console.WriteLine(s.pop() + " " + s.min());
 */ 
namespace Algorithm.StackAndQueue
{
    class CC3_2
    {
        public class Stack
        {
            StackNode head;
            StackNode helper;
            public void push(double val)
            {
                //Min
                if (helper != null)
                {
                    if (helper.Data > val)
                    {
                        StackNode h = new StackNode(val);
                        h.Previous = helper;
                        helper = h;
                    }
                }
                else
                {
                    StackNode h = new StackNode(val);
                    h.Previous = helper;
                    helper = h;
                }

                StackNode sn = new StackNode(val);
                sn.Previous = head;
                head = sn;
            }

            public double pop()
            {
                double val = head.Data;
                head = head.Previous;

                //Min
                if (helper != null)
                {
                    if (helper.Data  ==  val)
                    {
                        helper = helper.Previous;
                    }
                }

                return val;
            }

            public double min()
            {
                return helper.Data;
            }
        }
    }
}
