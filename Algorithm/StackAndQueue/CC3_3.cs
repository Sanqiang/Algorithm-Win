/*
             StackAndQueue.CC3_3.SetOfStack sos = new StackAndQueue.CC3_3.SetOfStack();
            sos.push(1); sos.push(2); sos.push(3); sos.push(4); sos.push(5); sos.push(6); sos.push(1); sos.push(2); sos.push(3);

            Console.WriteLine(sos.popAt(1));
            //Console.WriteLine(sos.pop() + " " + sos.pop() + " " + sos.pop() + " " + sos.pop() + " " + sos.pop() + " " + sos.pop() + " " + sos.pop());
            
 */ 
namespace Algorithm.StackAndQueue
{
    class CC3_3
    {
        public class SetOfStack
        {
            int volumn = 3;

            public SetOfStack(int volumn)
            {
                this.volumn = volumn;
            }
            public SetOfStack() { }

            System.Collections.Generic.List<Stack> set = new System.Collections.Generic.List<Stack>(1);

            public void push(double val)
            {
                if (set.Count == 0)
                {
                    Stack s = new Stack();
                    set.Add(s);
                }
                Stack lastest = set[set.Count - 1];
                if (lastest.getSize() == volumn)
                {
                    Stack s = new Stack();
                    set.Add(s);
                    lastest = set[set.Count - 1];
                }
                lastest.push(val);
            }

            public double peek()
            {
                return set[set.Count - 1].peek();
            }

            public double pop()
            {
                double val = set[set.Count - 1].pop();
                if (set[set.Count - 1].getSize() == 0 && set.Count > 1)
                {
                    set.RemoveAt(set.Count - 1);
                }
                return val;
            }

            public double popAt(int target)
            {
                double val = set[target].pop();
                if (set[set.Count - 1].getSize() == 0 && set.Count > 1)
                {
                    set.RemoveAt(set.Count - 1);
                }
                //Trade-off
                leftShift(target);

                return val;
            }

            private void leftShift(int target)
            {
                while (target + 1 < set.Count)
                {
                    set[target].push(set[target+1].popBottom());
                    target++;
                }
                if (set[target].getSize()==0)
                {
                    set.RemoveAt(set.Count - 1);
                }
            }
        }
    }
}
