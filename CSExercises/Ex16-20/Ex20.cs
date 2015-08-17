using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex20
    {
        static int read()
        {
            return (Convert.ToInt32(Console.ReadLine()));
        }
        private static double price(int a,int b,int c)
        {
            if (900 * a + 500 * b < 5000)
                return (900 * a + 500 * b + 700 * c);
            else
            {
                if (900 * a + 500 * b < 10000)
                    return ((900 * a + 500 * b) * 0.9 + 700 * c);
                else
                    return ((900 * a + 500 * b) * 0.85 + 700 * c);
            }
        }
        public static void Main(string[] args)
        {
            Console.Write("Ener quantity for TV:");
            int a = read();
            Console.Write("Ener quantity for DVD:");
            int b = read();
            Console.Write("Ener quantity for MP3:");
            int c = read();
            Console.WriteLine("Total price this order is ${0}",price(a,b,c));
        }
    }
}