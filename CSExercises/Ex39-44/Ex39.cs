using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        {
            int a = 1;
            for (int i = 1; i <= n; i++)
                a *= i;
                return a;
        }
        public static void Main()
        {
            Console.Write("Plesae input an integer number:");
            Console.WriteLine("The factorial is: {0}", Factorial(Convert.ToInt64(Console.ReadLine())));
        }
    }
}
