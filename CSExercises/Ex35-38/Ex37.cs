using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex37
    {
        static string title(string a)
        {
            string b = a.Substring(0,1).ToUpper();
            for (int i = 0; i < a.Length - 1; i++)
                if (a.Substring(i, 1) == " ")
                    b += a.Substring(i + 1, 1).ToUpper();
                else
                    b += a.Substring(i + 1, 1);
            return b;
        }
        public static void Main(string[] args)
        {
            Console.Write("Please input a sentence: ");
            string a = Console.ReadLine();
            Console.WriteLine(title(a));
        }
    }
}
