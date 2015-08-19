using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {
            bool a = false;
            for (int i = 0; i <= s1.Length - s2.Length; i++)
            {
                int j = 0;
                for (; j < s2.Length; j++)
                {
                    if (s1.Substring(i + j, 1) != s2.Substring(j,1))
                        break;
                }
                if (j == s2.Length)
                {
                    a = true;
                    break;
                }
            }
            return a;
        }
        public static void Main()
        {
            Console.Write("Please input string1: ");
            string s1 = Console.ReadLine();
            Console.Write("Please input string2: ");
            string s2 = Console.ReadLine();
            if (InString(s1, s2))
                Console.WriteLine("s2 occurs in s1");
            else
                Console.WriteLine("s2 doesn't occurs in s1");
        }
    }
}
