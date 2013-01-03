using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    class Composite
    {
    }

    abstract class AbstractTreeNode
    {
        int _data;
        protected List<AbstractTreeNode> _list;
        public abstract void add(AbstractTreeNode val);
    }

    class TreeLimb : AbstractTreeNode
    {
        public TreeLimb()
        {
            _list = new List<AbstractTreeNode>();
        }

        public override void add(AbstractTreeNode val)
        {
            _list.Add(val);
        }
    }

    class TreeLeaf : AbstractTreeNode
    {
        public TreeLeaf()
        {
            _list = null;
        }

        public override void add(AbstractTreeNode val)
        {
            //nothing
        }
    }
}
