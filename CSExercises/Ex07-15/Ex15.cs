using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex15
    {
        static int read()
        {
            return (Convert.ToInt32(Console.ReadLine()));
        }
        public static void Main(string[] args)
        {
            Console.Write("please input a three-digit integer: ");
            int k = read();
            int i = k;
            int a = i % 10;
            i = i - a;
            int b = (i % 100) / 10;
            i = i - (b * 10);
            int c = i / 100;
            if (k == a * a * a + b * b * b + c * c * c)
                Console.WriteLine("{0} is the Armstrong number", k);
            else
                Console.WriteLine("{0} is not the Armstrong number", k);
        }
    }
}