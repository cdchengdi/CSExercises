using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double b = Math.Sqrt(1.0 * a);
            int j = 0;
            for (int i = 2; i <= b; i++)
            {
                if (a % i == 0)                   
                    j = 1;
            }
            if (j == 0)
                Console.WriteLine("It's a Prime Number. ");
            else
                Console.WriteLine("It's not a Prime Number. ");
        }
    }
}
