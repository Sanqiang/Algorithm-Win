/*
  Microsoft.Q76.ComplexNode cn1 = new Microsoft.Q76.ComplexNode(1);
            Microsoft.Q76.ComplexNode cn2 = new Microsoft.Q76.ComplexNode(2);
            Microsoft.Q76.ComplexNode cn3 = new Microsoft.Q76.ComplexNode(3);
            Microsoft.Q76.ComplexNode cn4 = new Microsoft.Q76.ComplexNode(4);
            cn1.Next = cn2; cn2.Next = cn3; cn3.Next = cn4;
            cn1.Sibiling = cn3; cn2.Sibiling = cn4; cn4.Sibiling = cn1;
            Microsoft.Q76.ComplexNode loop = cn1;
            while (loop != null)
            {
                Console.WriteLine(loop.Data + " : " + (loop.Sibiling != null ? loop.Sibiling.Data.ToString() : "NULL"));
                loop = loop.Next;
            }
            Console.WriteLine("======");
            Microsoft.Q76.ComplexNode CLONE = cn1.Clone();
            loop = CLONE;
            while (loop != null)
            {
                Console.WriteLine(loop.Data + " : " + (loop.Sibiling != null ? loop.Sibiling.Data.ToString() : "NULL"));
                loop = loop.Next;
            }
 */
namespace Algorithm.Microsoft
{
    public class Q76
    {
        public class ComplexNode : LinkedList.LinkedNode
        {
            public ComplexNode Sibiling;
            public ComplexNode Next;
            public ComplexNode() { }
            public ComplexNode(double data) : base(data) { }
            public ComplexNode Clone()
            {
                //Double it!!
                ComplexNode loop = this;
                while (loop != null)
                {
                    ComplexNode loop_next = loop.Next;

                    ComplexNode cn = new ComplexNode(loop.Data);
                    loop.Next = cn;
                    cn.Next = loop_next;

                    loop = loop_next;
                }
                //Copy the sibling
                loop = this;
                while (loop != null)
                {
                    ComplexNode loop_sibling = loop.Sibiling;

                    if (loop_sibling != null)
                    {
                        loop.Next.Sibiling = loop_sibling.Next;
                    }


                    loop = loop.Next.Next;
                }
                //Split the Double Loop
                loop = this;
                ComplexNode head = loop.Next;
                while (loop != null)
                {
                    ComplexNode loop_next = loop.Next.Next;
                    if (loop_next == null)
                    {
                        break;
                    }
                    loop.Next.Next = loop_next.Next;
                    loop.Next = loop_next;
                    loop = loop_next;
                }
                loop.Next = null;
                return head;
            }
        }
    }
}
