using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex22
    {
        static int read()
        {
            return (Convert.ToInt32(Console.ReadLine()));
        }
        public static void Main(string[] args)
        {
            int A, B, a, b,c,d;
            Console.Write("Enter A: ");
            A = read();
            a = A;
            Console.Write("Enter B: ");
            B = read();
            b = B;
            while (a != b)
            {
                c = a > b ? a : b;
                d = a < b ? a : b;
                c -= d;
                a = c;
                b = d;

            }
            Console.WriteLine("HCF: {0}\nLCM: {1}",a,(double)A*B/a);

        }
    }
}
