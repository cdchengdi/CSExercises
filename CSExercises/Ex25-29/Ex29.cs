using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a interger number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            int b=1;
            for (int i = 2; b < a; i++)
            {
                b *= i;
                if (b == a)
                    j = 1;
            }
            if (j == 1)
                Console.WriteLine("{0} is a Perfect Number", a);
            else
                Console.WriteLine("{0} is not a Perfect Number", a);
        }
    }
}
