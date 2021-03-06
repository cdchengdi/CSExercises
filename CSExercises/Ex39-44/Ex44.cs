using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {
            string a = "";
            for (int i = 0; i < s.Length; i++)
                if (s.Substring(i, 1) != Convert.ToString(c1))
                    a += s.Substring(i, 1);
                else
                    a += Convert.ToString(c2);
            return a;
        }
        public static void Main()
        {
            Console.Write("Please input s: ");
            string s = Console.ReadLine();
            Console.Write("Please input c1: ");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Please input c2: ");
            char c2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Substitute(s,c1,c2));
        }
    }
}
