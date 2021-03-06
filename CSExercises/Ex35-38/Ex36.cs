using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex36
    {
        static string clear(string a)
        {
            string b="";
            for (int i = 0; i < a.Length; i++)
                if (a.Substring(i, 1).CompareTo("A") != -1 && "z".CompareTo(a.Substring(i, 1)) != 1)
                    b += a.Substring(i, 1);
            return b;
        }
        static void palindrome(string a)
        {
            int k = 0;
            a = a.ToUpper();
            for (int i = 0; i < a.Length / 2; i++)
                if (a.Substring(i, 1) != a.Substring(a.Length - 1 - i, 1))
                    k = 1;
            if (k == 1)
                Console.WriteLine("The phrase/sentence is not a palindome.");
            else
                Console.WriteLine("The phrase/sentence is a palindome.");
        }
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string a = Console.ReadLine();
            palindrome(a);
            Console.Write("Please enter a sentence: ");
            string b = Console.ReadLine();
            string c = clear(b);
            palindrome(c);
        }
    }
}
