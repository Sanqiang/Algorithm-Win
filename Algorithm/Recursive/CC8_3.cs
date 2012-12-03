/*
             System.Collections.ArrayList set = new System.Collections.ArrayList ();
            set.Add('A'); set.Add('B');
            //System.Collections.ArrayList subsets = Recursive.CC8_3.getSubSet(set); //Redundent
            System.Collections.ArrayList subsets = Recursive.CC8_3.getSubSetRecursive(set);
            //System.Collections.ArrayList subsets = Recursive.CC8_3.getSubSetEx(set);
            foreach (var subset_obj in subsets)
            {
                System.Collections.ArrayList subset = (System.Collections.ArrayList)subset_obj;
                foreach (var elem in subset)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }
 */ 
namespace Algorithm.Recursive
{
    class CC8_3
    {
        //Iterate
        public static System.Collections.ArrayList getSubSet(System.Collections.ArrayList set)
        {
            System.Collections.ArrayList result = new System.Collections.ArrayList();

            System.Collections.ArrayList empty = new System.Collections.ArrayList();
            empty.Add('@');
            result.Add(empty);
            for (int i = 0; i < set.Count; i++)
            {
                int result_count = result.Count;
                for (int j = 0; j < result_count; j++)
                {
                    System.Collections.ArrayList subset = (System.Collections.ArrayList)result[j];
                    System.Collections.ArrayList subset_clone = (System.Collections.ArrayList)subset.Clone();
                    subset_clone.Add(set[i]);
                    result.Add(subset_clone);
                }
                System.Collections.ArrayList subset_new_elem = new System.Collections.ArrayList();
                subset_new_elem.Add(set[i]);
                result.Add(subset_new_elem);
            }

            return result;
        }

        public static System.Collections.ArrayList getSubSetRecursive(System.Collections.ArrayList set, int index = 0)
        {
            System.Collections.ArrayList result = null;
            if (index == set.Count)
            {
                result = new System.Collections.ArrayList();
                System.Collections.ArrayList empty = new System.Collections.ArrayList();
                //empty.Add('@');
                result.Add(empty);
            }
            else
            {
                result = getSubSetRecursive(set, index + 1);
                object o = set[index];
                System.Collections.ArrayList more_subsets = new System.Collections.ArrayList();
                foreach (System.Collections.ArrayList subsets in result)
                {
                    System.Collections.ArrayList new_subset = new System.Collections.ArrayList();
                    new_subset.AddRange(subsets);
                    new_subset.Add(o);
                    more_subsets.Add(new_subset);
                }
                result.AddRange(more_subsets);
                //System.Collections.ArrayList subset_new_elem = new System.Collections.ArrayList();
                //subset_new_elem.Add(o);
                //result.Add(subset_new_elem);
                /*
                int result_loop_count = result_loop.Count;
                for (int i = 0; i < result_loop_count; i++)
                {
                    System.Collections.ArrayList new_subset = new System.Collections.ArrayList();
                    foreach (object o_pre in result_loop[i])
                    {
                        new_subset.Add(o_pre);
                    }
                    new_subset.Add(o);
                    result_loop.Add(new_subset);
                    //System.Collections.ArrayList subset_clone = (System.Collections.ArrayList)subset.Clone();
                    //subset_clone.Add(o);
                    //result_loop.Add(subset_clone);

                }
                System.Collections.ArrayList subset_new_elem = new System.Collections.ArrayList();
                subset_new_elem.Add(o);
                result_loop.Add(subset_new_elem);
                return result_loop;*/
            }
            return result;
        }

        public static System.Collections.ArrayList getSubSetEx(System.Collections.ArrayList set)
        {
            System.Collections.ArrayList result = new System.Collections.ArrayList();
            int numbers = 1 << set.Count;
            for (int i = 0; i < numbers; i++)
            {
                System.Collections.ArrayList subset = new System.Collections.ArrayList();
                int index = 0;
                int k = i;
                while (k>0)
                {
                    if ((k & 1) > 0)
                    {
                        subset.Add(set[index]);
                    }
                    k >>= 1;
                    index++;
                }
                result.Add(subset);

            }
            return result;
        }
    }
}
