/*
 Console.WriteLine(ArrayAndString.removeDuplicate.remove("aabbccd".ToCharArray()));
 */ 
namespace Algorithm.ArrayAndString
{
    public class removeDuplicate
    {
        public static char[] remove(char[] str)
        {
            int i = 0, a = 0, b = 1;
            while (a < str.Length && b < str.Length)
            {
                if (str[a] == str[b])
                {
                    ++b;
                }
                else
                {
                    str[i++] = str[a];
                    a = b;
                    b = a + 1;
                }
            }
            str[i++] = str[a];
            if (i < str.Length - 1)
            {
                str[i] = '$';
            }

            return str;
        }

        private static void exchange(char[] arr, int a, int b)
        {
            char tmp = arr[a];
            arr[a] = arr[b];
            arr[b] = tmp;
        }
    }
}
