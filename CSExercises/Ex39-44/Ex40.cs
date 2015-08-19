using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.Write("Plesae input an integer number between 1-25:");
            Console.WriteLine("The square root is: {0}", SQT(Convert.ToInt32(Console.ReadLine())));
        }

        public static double SQT(int y)
        {
            Random rnd = new Random();
            double G = rnd.Next(1, Convert.ToInt32(y - y % 1));
            for (double g; ; G = g)
            {
                g = (G + y / G) / 2;
                if ((G - g) < 0.000005 && (g - G) < 0.000005)
                    
                    break;
            }
             return G;
        }
    }
}
