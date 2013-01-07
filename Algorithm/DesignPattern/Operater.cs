using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    class Item
    {
        public int num;

        public Item(int _num)
        {
            this.num = _num;
        }

        public static Item operator +(Item i1, Item i2)
        {
            return new Item(i1.num + i2.num);
        }

        public static Item operator ++(Item i)
        {
            return new Item(i.num + 1);
        }

        public static Item operator -- (Item i)
        {
            return new Item(i.num + 1);
        }
    }
}
