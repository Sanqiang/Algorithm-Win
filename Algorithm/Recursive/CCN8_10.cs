/*
 Recursive.CCN8_10.Box[] list ={
                                               new Recursive.CCN8_10.Box(10, 29, 33)
                                              ,new Recursive.CCN8_10.Box(0, 0, 0)
                                              ,new Recursive.CCN8_10.Box(1, 1, 1)
                                              ,new Recursive.CCN8_10.Box(2, 2, 2)
                                              ,new Recursive.CCN8_10.Box(1, 2, 3)
                                              ,new Recursive.CCN8_10.Box(3, 3, 3)
                                              ,new Recursive.CCN8_10.Box(1, 2, 2)
                                              ,new Recursive.CCN8_10.Box(9, 5, 4)
                                          };
            System.Collections.Generic.List<Recursive.CCN8_10.Box> solution = Recursive.CCN8_10.createStack(list);
            foreach (var item in solution)
            {
                Console.WriteLine(item.ToString());
            }
 */ 
namespace Algorithm.Recursive
{
    class CCN8_10
    {

        public static System.Collections.Generic.List<Box> createStack(Box[] boxes,
            System.Collections.Generic.Dictionary<Box, System.Collections.Generic.List<Box>> cache = null,
            Box bottom = null)
        {
            if (cache == null)
            {
                cache = new System.Collections.Generic.Dictionary<Box, System.Collections.Generic.List<Box>>();
            }
            else
            {
                if (bottom != null && cache.ContainsKey(bottom))
                {
                    return cache[bottom];
                }
            }

            System.Collections.Generic.List<Box> max_list = null;
            //max_list = new System.Collections.Generic.List<Box>();
            foreach (Box loop_box in boxes)
            {
                if (loop_box.isAbove(bottom))
                {
                    System.Collections.Generic.List<Box> list = createStack(boxes, cache, loop_box);
                    if (max_list == null)
                    {
                        max_list = list;
                    }
                    if (max_list != null && list.Count > max_list.Count)
                    {
                        max_list = list;
                    }
                }
            }
            if (max_list == null)
            {
                max_list = new System.Collections.Generic.List<Box>();
            }

            if (bottom != null)
            {
                max_list.Add(bottom);
                cache.Add(bottom, max_list);
            }
            return max_list;
        }

        public class Box
        {
            public int w;
            public int h;
            public int d;
            public Box() { }
            public Box(int _w, int _h, int _d)
            {
                this.w = _w;
                this.h = _h;
                this.d = _d;
            }

            public bool isAbove(Box b)
            {
                if (b == null)
                {
                    return true;
                }
                else
                {
                    return this.w < b.w && this.h < b.h && this.d < b.d;
                }
            }

            public bool isBelow(Box b)
            {
                return this.w > b.w && this.h > b.h && this.d > b.d;
            }

            public string ToString()
            {
                return "W:" + this.w + " H:" + this.h + " D:" + this.d;
            }
        }
    }
}
