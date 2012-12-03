/*
 Console.Write(ArrayAndString.StringInclude.verify("abcU", "cchhssab"));
 */ 
/*
 			Console.WriteLine(ArrayAndString.StringInclude.verifyEx("abc","aaassswwbbbwdddccc"));
			Console.WriteLine(ArrayAndString.StringInclude.verifyEx("abc","aaaccc"));

			Console.WriteLine(ArrayAndString.StringInclude.verifyEx2("b","acccb"));
			Console.WriteLine(ArrayAndString.StringInclude.verifyEx2("cb","ab"));
 */ 
using System;

namespace Algorithm.ArrayAndString
{
	public class StringInclude
	{
        //Two ACS2 Strings, verify whether every character in one string is included in another string
        public static bool verify(string small, string big)
        {
            if (small.Length==0 || big.Length ==0)
            {
                return false;
            }
            char[] big_arr  =big.ToCharArray();
            Algorithm.TreeAndGraph.BinarySearchTree dic = new TreeAndGraph.BinarySearchTree(big_arr[0]);
            for (int i = 1; i < big_arr.Length; i++)
            {
                dic.AddTreeNode(big_arr[i]);
            }

            foreach (char c in small.ToCharArray())
            {
                if (!dic.FindTreeNode(c))
                {
                    return false;
                }
            }

            return true;
        }

		//Another Solution (array no need to interate)
		public static bool verifyEx2(string small, string big)
		{
			int tab_big = 0;
			foreach (char c in big) {
				int length = c-'a';
				tab_big |= (1<<length);
			}
			foreach (char c in small) {
				int length = c - 'a';
				if (((1<<length)&tab_big)==0) {
					return false;
				}
			}
			return true;
		}


		public static bool verifyEx(string small, string big)
		{
			bool[] arr = new bool[256];
			foreach (char c in big) {
				arr[c]=true;
			}
			foreach (char c in small) {
				if(!arr[c])return false;
			}
			return true;
		}

	}
}

