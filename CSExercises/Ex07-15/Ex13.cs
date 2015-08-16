using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        static double read()
        {
            return (Convert.ToDouble(Console.ReadLine()));
        }
        public static void Main(string[] args)
        {
            Console.Write("please input the distance(km):");
            double d = read();
            Console.WriteLine("the fee is {0:0.00}$", Math.Ceiling((2.4 + d * 0.4) * 10) / 10);   
        }
    }
}
