using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex24
    {
        static double read()
        {
            return (Convert.ToDouble(Console.ReadLine()));
        }
        public static void Main(string[] args)
        {
            Console.Write("Please input a numer for finding the suqare root: ");
            double N = read();
            Random rnd = new Random();
            double G = rnd.Next(1,Convert.ToInt32(N-N%1));
            for (double g; ; G = g)
            {
                g = (G + N / G) / 2;
                if ((G - g) < 0.000005 && (g - G) < 0.000005)
                    break;
            }
            Console.WriteLine("the square root for {0} is {1:0.00000}",N,G);
        }
    }
}
