using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        static int read()
        {
            return (Convert.ToInt32(Console.ReadLine()));
        }
        public static void Main(string[] args)
        {
            Console.Write("Please input the number:");
            int a = read();
            Console.WriteLine("The square of {0} is {1}",a,a*a);           
        }
    }
}
