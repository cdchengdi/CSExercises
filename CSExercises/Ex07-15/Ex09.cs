using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        static double read()
        {
            return (Convert.ToDouble(Console.ReadLine()));
        }
        public static void Main(string[] args)
        {
            Console.Write("Please input the value of x:");
            double x = read();
            Console.WriteLine("y is {0}", 2*x*x-4*x+3);     
        }
    }
}
