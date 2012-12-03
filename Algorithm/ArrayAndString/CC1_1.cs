/*
 			Console.WriteLine(ArrayAndString.CC1_1.verifyUniqueChar("abcd"));
 */
using System;

namespace Algorithm.ArrayAndString
{
	public class CC1_1
	{
		public static bool verifyUniqueChar(string str)
		{
			int tab = 0; //make sure the space
			foreach (char c in str) {
				int length = c-'a';
				if((tab&(1<<length))>0)return false;
				tab |=  (1<<length);
			}
			return true;
		}
	}
}

