/*
             SortAndSearch.CCN9_8.BinarySearchTreeV5 bst = new SortAndSearch.CCN9_8.BinarySearchTreeV5(3);
            bst.insert(7); bst.insert(2); bst.insert(1); bst.insert(2.5);
            Console.WriteLine(bst.track(2.5));
            Console.WriteLine(bst.track(7));
 */ 
namespace Algorithm.SortAndSearch
{
    class CCN9_8
    {
        public class BinarySearchTreeV5
        {
            public BinarySearchTreeV5 LeftNode;
            public BinarySearchTreeV5 RightNode;
            public double Data;

            public BinarySearchTreeV5(double _data)
            {
                this.Data = _data;
            }

            public void insert(double value)
            {
                if (value <= this.Data)
                {
                    if (LeftNode==null)
                    {
                        BinarySearchTreeV5 node = new BinarySearchTreeV5(value);
                        this.LeftNode = node;
                    }
                    else
                    {
                        LeftNode.insert(value);
                    }
                    ++TrackNum;
                }
                else
                {
                    if (RightNode == null)
                    {
                        BinarySearchTreeV5 node = new BinarySearchTreeV5(value);
                        this.RightNode = node;
                    }
                    else
                    {
                        RightNode.insert(value);
                    }
                }
            }

            public int TrackNum = 0;
            public int track(double value)
            {
                if (value == this.Data)
                {
                    return TrackNum;
                }else if (value<this.Data)
                {
                    if (LeftNode == null)
                    {
                        return -1;
                    }
                    else
                    {
                        return LeftNode.track(value);
                    }
                }
                else
                {
                    if (RightNode==null)
                    {
                        return -1;
                    }
                    else
                    {
                        return TrackNum + 1 + RightNode.track(value); 
                    }
                }

            }
        }
    }
}
