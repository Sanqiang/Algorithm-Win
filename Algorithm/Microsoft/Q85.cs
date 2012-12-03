
namespace Algorithm.Microsoft
{
    class Q85
    {
        //85.1
        /*
            Console.WriteLine(Microsoft.Q85.concatString("zhaosan", "sanqiang"));
            Console.WriteLine(Microsoft.Q85.concatString("zhaoabc", "q"));
         */ 
        public static string concatString(string str1, string str2)
        {
            int pivot = 0;
            int index = 0;
            //bool find = false;
            while (index < str1.Length)
            {
                if (str1[index] == str2[pivot])
                {
                    index++; pivot++;
                    if (index == str1.Length)
                    {
                        //find = true;
                        break;
                    }
                }
                else
                {
                    index++;
                    pivot = 0;
                }
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            //if (find)
            //{
                sb.Append(str1);
                for (int i = pivot; i < str2.Length; i++)
                {
                    sb.Append(str2[i]);
                }
            //}
            //else
            //{
            //    sb.Append(str1).Append(str2);
            //}

            return sb.ToString();
        }

        //85.2 KMP
        //reference to Algorithm.ArrayAndString.KMP
    }
}
