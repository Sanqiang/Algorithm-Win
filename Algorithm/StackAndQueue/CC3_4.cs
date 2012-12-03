/*
             StackAndQueue.CC3_4.Hanoi h = new StackAndQueue.CC3_4.Hanoi(5);
            Console.Write(h.toString());
            h.run();

            Console.Write(h.toString());
 */ 
namespace Algorithm.StackAndQueue
{
    class CC3_4
    {
        public class Hanoi
        {
            int n;
            System.Collections.Generic.List<Stack> tows = new System.Collections.Generic.List<Stack>();
            public Hanoi(int n)
            {
                this.n = n;
                for (int i = 0; i < 3; i++)
                {
                    tows.Add(new Stack());
                }
                for (int i = n; i > 0; i--)
                {
                    tows[0].push(i);
                }
            }

            public Stack getOrigin()
            {
                return tows[0];
            }

            public void run()
            {
                move(n, tows[2], tows[1], tows[0]);
            }

            public void move(int n, Stack destination, Stack loop, Stack original, bool first = true)
            {
                if (n==0)
                {
                    return;
                }
                move(n - 1, loop, destination, original);
                destination.push(original.pop());
                move(n - 1, destination, original, loop);

            }

            public string toString()
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.AppendLine("\r\nRob1:");
                sb.Append(tows[0].toString());
                sb.AppendLine("\r\nRob2:");
                sb.Append(tows[1].toString());
                sb.AppendLine("\r\nRob3:");
                sb.Append(tows[2].toString());         

                return sb.ToString();
            }

        }
    }
}
