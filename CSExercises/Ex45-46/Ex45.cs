using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the amount: ");
            int i = Convert.ToInt32(100 * Convert.ToDouble(Console.ReadLine()));
            for (int j = 0; j < i / 100; j++)
                Console.WriteLine("100c");
            i -= 100 * (i / 100);
            for (int j = 0; j < i / 50; j++)
                Console.WriteLine("50c");
            i -= 50 * (i / 50);
            for (int j = 0; j < i / 20; j++)
                Console.WriteLine("20c");
            i -= 20 * (i / 20);
            for (int j = 0; j < i / 10; j++)
                Console.WriteLine("10c");
            i -= 10 * (i / 10);
            for (int j = 0; j < i / 5; j++)
                Console.WriteLine("5c");
        }
    }
}
