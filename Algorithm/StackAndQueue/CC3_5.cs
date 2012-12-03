/*
 
            StackAndQueue.CC3_5.MyQueueFrom2Stack q = new StackAndQueue.CC3_5.MyQueueFrom2Stack();
            q.add(1); q.add(2); q.add(3); q.add(4); q.add(5);
            Console.WriteLine(q.remove() + " " + q.getSize());
            q.add(6);
            Console.WriteLine(q.remove() + " " + q.getSize());
            Console.WriteLine(q.remove() + " " + q.getSize());
            Console.WriteLine(q.remove() + " " + q.getSize());
            Console.WriteLine(q.remove() + " " + q.getSize());
            Console.WriteLine(q.remove() + " " + q.getSize());
 */ 
namespace Algorithm.StackAndQueue
{
    class CC3_5
    {
        public class MyQueueFrom2Stack
        {
            Stack top = new Stack();
            Stack bottom = new Stack();

            public void add(double val)
            {
                top.push(val);
            }

            public double remove()
            {
                if (bottom.getSize() == 0)
                {
                    tranfer();
                }
                return bottom.pop();
            }

            public double peek()
            {
                if (bottom.getSize() == 0)
                {
                    tranfer();
                }
                return bottom.peek();
            }

            private void tranfer()
            {
                while (top.getSize() > 0)
                {
                    bottom.push(top.pop());
                }
            }

            public int getSize()
            {
                return top.getSize() + bottom.getSize();
            }
        }

    }
}
