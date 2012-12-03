/*
             Console.WriteLine(ArrayAndString.CC1_8.verifyRotate("abc", "bca"));
            Console.WriteLine(ArrayAndString.CC1_8.verifyRotate("abc", "cba"));
 */ 
namespace Algorithm.ArrayAndString
{

    public class CC1_8
    {
        public static bool verifyRotate(string str1, string str2)
        {
            if (!str1.Length.Equals(str2.Length))
            {
                return false;
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder(str1);
            sb.Append(str1);
            return sb.ToString().Contains(str2);
        }
    }
}
