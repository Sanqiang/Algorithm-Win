/*
            double[] push = { 1, 2, 3, 4, 5 };
            //double[] pop = { 4, 3, 2, 1, 5 };
            double[] pop = { 5, 3, 2, 1, 4 };
            Console.WriteLine(Microsoft.Q29.verifyPopFromPush(push, pop));
            Console.WriteLine(Microsoft.Q29.validatePushPop(pop));
 */
namespace Algorithm.Microsoft
{
    class Q29
    {
        public static bool verifyPopFromPush(double[] push, double[] pop)
        {
            int index_push = 0;
            int index_pop = 0;
            System.Collections.Stack s = new System.Collections.Stack();

            while (true)
            {
                while (s.Count == 0 || pop[index_pop] != (double)s.Peek())
                {
                    if (index_push > push.Length - 1)
                    {
                        break;
                    }
                    s.Push(push[index_push]);
                    index_push++;

                }

                if ((double)s.Pop() != pop[index_pop])
                {
                    break;
                }
                index_pop++;
                if (index_pop > pop.Length - 1)
                {
                    break;
                }

            }

            if (index_push == push.Length && index_pop == pop.Length && s.Count == 0)
            {
                return true;
            }

            return false;
        }

        //revision:clear 12/2/2012 
        public static bool validatePushPop(double[] pop)
        {
            int i = 0, length = pop.Length;
            bool[] positioned = new bool[1 + length];
            System.Collections.Generic.Stack<int> s = new System.Collections.Generic.Stack<int>();
            while (i < length)
            {
                if (s.Count == 0 || s.Peek() != pop[i])
                {
                    int n = 1; bool f = true;
                    while (n <= pop[i])
                    {
                        if (!positioned[n])
                        {
                            f = false;
                            s.Push(n);
                            positioned[n] = true;
                        }
                        n++;
                    }
                    if (f)
                    {
                        return false;
                    }
                }
                else if (s.Count != 0 && s.Peek() == pop[i])
                {
                    s.Pop();
                    i++;
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
