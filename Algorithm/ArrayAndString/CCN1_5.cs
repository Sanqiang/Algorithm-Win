/*
             Console.WriteLine(ArrayAndString.CCN1_5.compressStr("aaaaabbbbccecaaas"));
            Console.WriteLine(ArrayAndString.CCN1_5.compressStr("asp"));
 */ 
namespace Algorithm.ArrayAndString
{

    public class CCN1_5
    {
        public static string compressStr(string str)
        {
            if (str.Length <= 1)
            {
                return str;
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            char last = str[0];
            int count = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals(last))
                {
                    count++;
                }
                else
                {
                    sb.Append(last).Append(count);
                    count = 1;
                    last = str[i];
                }
            }
            sb.Append(last).Append(count);
            if (sb.ToString().Length >= str.Length)
            {
                return str;
            }
            else
            {
                return sb.ToString();
            }
        }
    }
}
