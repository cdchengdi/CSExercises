using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        static double read()
        {
            return (Convert.ToDouble(Console.ReadLine()));
        }
        public static void Main(string[] args)
        {
            Console.Write("Please input the Centifgrade:");
            double C = read();
            Console.WriteLine("Fahrenheit is {0}", C*1.8+32);  
        }
    }
}
