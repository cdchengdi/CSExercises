using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        static double read()
        {
            return (Convert.ToDouble(Console.ReadLine()));
        }
        public static void Main(string[] args)
        {
            Console.Write("Please input the salary:");
            double a = read();
            Console.WriteLine("The total income is {0}", a*(1+0.03+0.1));  
        }
    }
}
