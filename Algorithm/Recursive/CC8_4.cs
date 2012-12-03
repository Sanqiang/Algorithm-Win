/*
            System.Collections.Generic.List<string> result = Recursive.CC8_4.getPermutation("ABC*");
            foreach (var item in result)
            {
                //Console.WriteLine(item);
            }
            System.Collections.Generic.List<string> result2 = Recursive.CC8_4.getPermutationV5("DEF");
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
 */
namespace Algorithm.Recursive
{
    class CC8_4
    {

        public static System.Collections.Generic.List<string> getPermutation(string str, int index = 0, System.Collections.Generic.List<string> sets = null)
        {
            if (index == str.Length)
            {
                return sets;
            }
            System.Collections.Generic.List<string> current_result = new System.Collections.Generic.List<string>();
            string c = str.Substring(index, 1);

            if (sets == null)
            {
                current_result.Add(c);
            }else if (sets != null)
            {
                foreach (string item in sets)
                {
                    for (int i = 0; i <= item.Length; i++)
                    {
                        current_result.Add(insertStr(item, i, c));
                    }
                }
            }

            return getPermutation(str, index + 1, current_result);
        }

        private static string insertStr(string ori_str, int index, string insert_char)
        {
            return ori_str.Substring(0, index) + insert_char + ori_str.Substring(index);
        }

        //Idea of Recursive 
        public static System.Collections.Generic.List<string> getPermutationV5(string str)
        {
            if (str == null)
            {
                return null;
            }
            System.Collections.Generic.List<string> solutions = new System.Collections.Generic.List<string>();
            if (str.Length == 0)
            {
                solutions.Add("");
                return solutions;
            }
            //solutions.Add(str[0].ToString());
            string remaining = str.Substring(1);
            System.Collections.Generic.List<string> current_solutions = getPermutationV5(remaining);
            foreach (string item in current_solutions)
            {
                for (int i = 0; i <= item.Length; i++)
                {
                    string new_item =  insertStr(item, i, str[0].ToString());
                    solutions.Add(new_item);
                }
            }
            return solutions;
        }
    }
}
