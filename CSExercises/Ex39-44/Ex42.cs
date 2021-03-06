using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            int k = -1;
            for (int i = 0; i <= s1.Length - s2.Length; i++)
            {
                int j = 0;
                for (; j < s2.Length; j++)
                {
                    if (s1.Substring(i + j, 1) != s2.Substring(j, 1))
                        break;
                }
                if (j == s2.Length)
                {
                    k = i;
                    break;
                }
            }
            return k;
        }
        public static void Main(string[] args)
        {
            Console.Write("Please input string1: ");
            string s1 = Console.ReadLine();
            Console.Write("Please input string2: ");
            string s2 = Console.ReadLine();
            if (FindWord(s1, s2)!=-1)
                Console.WriteLine("s2 occurs in s1 by starting at the {0} in s1",FindWord(s1,s2));
            else
                Console.WriteLine("s2 doesn't occurs in s1");
        }
    }
}
