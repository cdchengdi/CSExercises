using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex19
    {
        static double read()
        {
            return (Convert.ToDouble(Console.ReadLine()));
        }
        private static double cost(double a)
        {
            if (a <= 0.5)
                return 2.4;
            else
            {
                if (a <= 9)
                    return (2.4 + 0.4 * (a - 0.5));
                else
                    return (2.4 + 8.5 * 0.4 + 0.5 * (a - 9));
            }
        }
        public static void Main(string[] args)
        {
            Console.Write("Please input the lentgh you travelled(km): ");
            double a=read();
            Console.WriteLine("the cost is {0}",cost(a));
        }
    }
}