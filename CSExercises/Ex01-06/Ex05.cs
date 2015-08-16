using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        static double read()
        {
            return (Convert.ToDouble(Console.ReadLine()));
        }
        public static void Main(string[] args)
        {
            Console.Write("Please input the number:");
            double a = read();
            Console.WriteLine("The square root of {0} is {1:0.000}", a, Math.Sqrt(a));  
        }
    }
}
