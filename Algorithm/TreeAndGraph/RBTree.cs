using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.TreeAndGraph
{
    class RBTree
    {
        public enum CType
        {
            RED, BLACK
        }
        public class RBTreeNode
        {
            public double Data;
            public RBTreeNode Left;
            public RBTreeNode Right;
            public RBTreeNode Parent;
            public CType Color;
            public RBTreeNode(double data)
            {
                Color = CType.BLACK;
                this.Data = data;
            }

            public RBTreeNode(double data, RBTreeNode left, RBTreeNode right, RBTreeNode parent)
            {
                Color = CType.BLACK;
                this.Data = data;
                this.Left = left;
                this.Right = right;
                this.Parent = parent;
            }

            //public override bool Equals(RBTreeNode obj)
            //{
            //    return Data.Equals(obj.Data) && Left.Equals(obj.Left) && Right.Equals(obj.Right) && Parent.Equals(obj.Parent) && Color.Equals(obj.Color);
            //}
        }

        public RBTreeNode root = null;

        public void insert(double data)
        {
            if (root == null)
            {
                root = new RBTreeNode(data);
            }
            else
            {
                RBTreeNode parent = null;
                RBTreeNode current = root;
                do
                {
                    parent = current;
                    if (current.Data >= data)
                    {
                        current = current.Left;
                    }
                    else
                    {
                        current = current.Right;
                    }
                } while (current != null);
                current = new RBTreeNode(data, null, null, parent);
                if (current.Data >= data)
                {
                    parent.Left = current;
                }
                else
                {
                    parent.Right = current;
                }
                fixAfterInsert(current);
            }
        }

        private void fixAfterInsert(RBTreeNode x)
        {
            x.Color = CType.RED;
            if (parentOf(x) == leftOf(parentOf(parentOf(x))))
            {
                RBTreeNode uncle = rightOf(parentOf(parentOf(x)));
                if (colorOf(uncle) == CType.RED)
                {
                    setColor(uncle, CType.BLACK);
                    setColor(parentOf(x), CType.BLACK);
                    setColor(parentOf(parentOf(x)), CType.RED);
                    x = parentOf(parentOf(x));
                }
                else
                {
                    if (rightOf(parentOf(x)) == x)
                    {
                        x = parentOf(x);
                        rotateLeft(x);
                    }
                    setColor(parentOf(x), CType.BLACK);
                    setColor(parentOf(parentOf(x)), CType.RED);
                    rotateRight(parentOf(parentOf(x)));
                }
            }
            else
            {
                RBTreeNode uncle = leftOf(parentOf(parentOf(x)));
                if (colorOf(uncle) == CType.RED)
                {
                    setColor(uncle, CType.BLACK);
                    setColor(parentOf(x), CType.BLACK);
                    setColor(parentOf(parentOf(x)), CType.RED);
                    x = parentOf(parentOf(x));
                }
                else
                {
                    if (leftOf(parentOf(x)) == x)
                    {
                        x = parentOf(x);
                        rotateRight(x);
                    }
                    setColor(parentOf(x), CType.BLACK);
                    setColor(parentOf(parentOf(x)), CType.RED);
                    rotateLeft(parentOf(parentOf(x)));
                }

            }
            setColor(root, CType.BLACK);

        }

        public void remove(double data)
        {
            RBTreeNode pending = search(data);
            if (pending == null)
            {
                return;
            }
            if (pending.Left != null && pending.Right != null)
            {
                RBTreeNode l = pending.Left;
                while (l.Right != null)
                {
                    l = l.Right;
                }
                pending.Data = l.Data;
                pending = l;
            }
            RBTreeNode replace = pending.Left != null ? pending.Left : pending.Right;
            if (replace != null)
            {
                replace.Parent = pending.Parent;
                if (parentOf(pending) == null)
                {
                    root = replace;
                }
                else if (leftOf(parentOf(pending)) == pending)
                {
                    pending.Parent.Left = replace;
                }
                else
                {
                    pending.Parent.Right = replace;
                }
                pending = pending.Left = pending.Right = pending.Parent = null;
                if (colorOf(pending) == CType.BLACK)
                {
                    fixAfterDelete(replace);
                }
            }
            else if (parentOf(replace) == null)
            {
                root = null;
            }
            else
            {
                if (colorOf(pending) == CType.BLACK)
                {
                    fixAfterDelete(pending);
                }
                if (parentOf(pending) != null)
                {
                    if (leftOf(parentOf(pending)) == pending)
                    {
                        pending.Parent.Left = null;
                    }
                    else if (rightOf(parentOf(pending)) == pending)
                    {
                        pending.Parent.Right = null;
                    }
                    pending.Parent = null;
                }
            }
        }

        private void fixAfterDelete(RBTreeNode x)
        {
            while (x != root && colorOf(x) == CType.BLACK)
            {
                if (leftOf(parentOf(x)) == x)
                {
                    RBTreeNode uncle = rightOf(parentOf(x));
                    if (colorOf(uncle)==CType.RED)
                    {
                        setColor(uncle, CType.BLACK);
                        setColor(parentOf(x), CType.RED);
                        rotateLeft(parentOf(x));
                        uncle = rightOf(parentOf(x));
                    }
                    if (colorOf(leftOf(uncle)) == CType.BLACK && colorOf(rightOf(x))==CType.RED)
                    {
                        setColor(uncle, CType.RED);
                        x = parentOf(x);
                    }
                    else
                    {
                        if (colorOf(rightOf(uncle)) == CType.BLACK)
                        {
                            setColor(leftOf(uncle), CType.BLACK);
                            setColor(uncle, CType.RED);
                            rotateRight(uncle);
                            uncle = rightOf(parentOf(x));
                        }
                        setColor(uncle, colorOf(parentOf(x)));
                        setColor(parentOf(x), CType.BLACK);
                        setColor(rightOf(uncle), CType.BLACK);
                        rotateLeft(parentOf(x));
                        x = root;
                    }
                }
                else
                {
                    RBTreeNode uncle = leftOf(parentOf(x));
                    if (colorOf(uncle) == CType.RED)
                    {
                        setColor(uncle, CType.BLACK);
                        setColor(parentOf(x), CType.RED);
                        rotateRight(parentOf(x));
                        uncle = leftOf(parentOf(x));
                    }
                    if (colorOf(leftOf(uncle)) == CType.BLACK && colorOf(rightOf(uncle))==CType.BLACK)
                    {
                        setColor(uncle, CType.RED);
                        x = parentOf(x);
                    }
                    else
                    {
                        if (colorOf(leftOf(uncle))==CType.BLACK)
                        {
                            setColor(rightOf(uncle), CType.BLACK);
                            setColor(uncle, CType.RED);
                            rotateLeft(uncle);
                            uncle = leftOf(parentOf(x));
                        }
                        setColor(uncle, colorOf(parentOf(x)));
                        setColor(parentOf(x), CType.BLACK);
                        setColor(leftOf(uncle), CType.BLACK);
                        rotateRight(parentOf(x));
                        x = root;
                    }
                }
            }
            setColor(x, CType.BLACK);
        }

        public RBTreeNode search(double data)
        {
            RBTreeNode loop = root;
            while (loop != null)
            {
                if (loop.Data == data)
                {
                    return loop;
                }
                if (loop.Data < data)
                {
                    loop = loop.Right;
                }
                else
                {
                    loop = loop.Left;
                }
            }
            return null;
        }

        private void rotateLeft(RBTreeNode p)
        {
            if (p != null)
            {
                RBTreeNode x = rightOf(p);
                RBTreeNode tail = leftOf(x);
                p.Right = tail;
                if (tail != null)
                {
                    tail.Parent = p;
                }
                x.Parent = p.Parent;
                if (parentOf(p) == null)
                {
                    root = x;
                }
                else if (leftOf(parentOf(p)) == p)
                {
                    p.Parent.Left = x;
                }
                else
                {
                    p.Parent.Right = x;
                }
                x.Left = p;
                p.Parent = x;
            }
        }

        private void rotateRight(RBTreeNode p)
        {
            if (p != null)
            {
                RBTreeNode x = leftOf(p);
                RBTreeNode tail = rightOf(x);
                p.Left = tail;
                if (tail != null)
                {
                    tail.Parent = p;
                }
                x.Parent = p.Parent;
                if (parentOf(p) == null)
                {
                    root = x;
                }
                else if (rightOf(parentOf(p)) == p)
                {
                    p.Parent.Right = x;
                }
                else
                {
                    p.Parent.Left = x;
                }
                x.Right = p;
                p.Parent = x;
            }
        }

        private RBTreeNode leftOf(RBTreeNode x)
        {
            return x == null ? null : x.Left;
        }

        private RBTreeNode rightOf(RBTreeNode x)
        {
            return x == null ? null : x.Right;
        }

        private RBTreeNode parentOf(RBTreeNode x)
        {
            return x == null ? null : x.Parent;
        }

        private CType colorOf(RBTreeNode x)
        {
            return x == null ? CType.BLACK : x.Color;
        }

        private void setColor(RBTreeNode x, CType color)
        {
            if (x != null)
            {
                x.Color = color;
            }
        }
    }
}

