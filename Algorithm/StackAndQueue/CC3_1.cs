/*
             //StackAndQueue.CC3_1.StackEx se = new StackAndQueue.CC3_1.StackEx();
            StackAndQueue.CC3_1.Stack se = new StackAndQueue.CC3_1.Stack();
            se.push(0, 1);
            se.push(0, 2);
            se.push(1, 3);
            se.push(1, 4);
            Console.WriteLine(se.peek(1));
            Console.WriteLine(se.peek(1));
            Console.WriteLine(se.pop(0));
            Console.WriteLine(se.pop(0));
            Console.WriteLine(se.isEmpty(0));
 */
namespace Algorithm.StackAndQueue
{
    class CC3_1
    {
        public class Stack
        {
            private double[] arr = new double[300];
            private int[] positions = { -1, -1, -1 };
            public Stack()
            {
                positions[0] = 0;
                positions[1] = arr.Length / 3 * 1;
                positions[2] = arr.Length / 3 * 2;
            }

            public void push(int target, double val)
            {
                if (positions[target] + 1 > 100)
                {
                    throw new System.Exception("Out of Range");
                }
                ++positions[target];
                arr[getBaseAddress(target)] = val;
            }

            public double peek(int target)
            {
                return arr[getBaseAddress(target)];
            }

            public double pop(int target)
            {
                if (positions[target] == -1)
                {
                    throw new System.Exception("Out of Range");
                }
                --positions[target];
                return arr[getBaseAddress(target)];
            }

            public bool isEmpty(int target)
            {
                return positions[target] == -1;
            }

            private int getBaseAddress(int target)
            {
                return target * 100 + positions[target];
            }
        }

        public class StackEx
        {
            private double[] arr = new double[300];
            private StackNode[] Pointers = { null, null, null };
            private int Used = 0;

            public void push(int target, double val)
            {
                Used++;
                arr[Used] = val;
                StackNode sn = new StackNode(Used);
                sn.Previous = Pointers[target];
                Pointers[target] = sn;
            }

            public double peek(int target)
            {
                return Pointers[target].Data;
            }

            public double pop(int target)
            {
                double val = Pointers[target].Data;
                Pointers[target] = Pointers[target].Previous;
                arr[Used--] = 0;
                return val;
            }

            public bool isEmpty(int target)
            {
                return Pointers[target] == null;
            }
        }

        public class StackV5
        {
            public int size = 0;//used
            public int num_stack = 3;
            public int default_size = 3;
            public int[] buffer = null;
            public StackData[] stacks = null;
            public StackV5()
            {
                this.buffer = new int[num_stack * default_size];
                this.stacks = new StackData[]{
                    new StackData(0,default_size),
                    new StackData(default_size,default_size),
                    new StackData(default_size*2,default_size),
                };
            }

            public int getSize()
            {
                return stacks[0].size + stacks[1].size + stacks[2].size;
            }

            private int next(int index)
            {
                if (index + 1 == buffer.Length)
                {
                    return 0;
                }
                else
                {
                    return index + 1;
                }
            }

            private int last(int index)
            {
                if (index - 1 == -1)
                {
                    return buffer.Length - 1;
                }
                else
                {
                    return index - 1;
                }
            }

            private void shift(int target)
            {
                StackData s = stacks[(target + 1) % num_stack];
                if (s.size >= s.capacity)
                {
                    shift(target + 1);
                }
                for (int i = (s.start + s.capacity - 1)%(num_stack * default_size); s.isWithinStack(i, num_stack * default_size); i = last(i))
                {
                    buffer[i] = buffer[last(i)];
                }
                buffer[s.start] = -1;
                s.capacity--;
                s.start = next(s.start);
                s.pointer = next(s.pointer);
            }

            public void Push(int val, int target)
            {
                StackData s = stacks[target];
                if (s.size == s.capacity)
                {
                    if (getSize() >= default_size * num_stack)
                    {
                        throw new System.Exception("Out of Range");
                    }
                    else
                    {
                        shift(target + 1);
                        s.capacity++;
                    }
                    s.size++;
                    buffer[next(s.pointer)] = val;
                }
            }

            public int Pop(int target)
            {
                StackData s = stacks[target];
                if (s.size==0)
                {
                    throw new System.Exception("Out of Range");
                }
                int val = buffer[s.pointer];
                
                buffer[s.pointer] = -1;
                s.pointer = last(s.pointer);
                s.size--;
                return 1;
            }

            public int Peek(int target)
            {
                int pointer = stacks[target].pointer;
                return buffer[pointer];
            }
        }

        public class StackData
        {
            public int start;
            public int pointer;
            public int size = 0;
            public int capacity;
            public StackData(int _start, int _capacity)
            {
                this.start = _start;
                this.pointer = _start - 1;
                this.capacity = _capacity;
            }

            public bool isWithinStack(int index, int total_size)
            {
                if (start <= index && index < (start + capacity))
                {
                    return true;
                }
                else if (start + capacity > total_size && index < (start + capacity) % total_size)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
