/*
 Console.WriteLine(ArrayAndString.CC1_5.replaceWhiteSpace("abc ab c  a b c"));
 */
namespace Algorithm.ArrayAndString
{
    class CC1_5
    {
        public static string replaceWhiteSpace(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c.Equals(' '))
                {
                    count++;
                }   
            }
            int length = str.Length + count * 2;
            char[] result = new char[length];
            int index = 0;
            foreach (char c in str)
            {
                if (c.Equals(' '))
                {
                    result[index++] = '%';
                    result[index++] = '2';
                    result[index++] = '0';
                }
                else
                {
                    result[index++] = c;
                }
            }

            return new string(result);
        }
    }
}
