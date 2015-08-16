using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        static double read()
        {
            return (Convert.ToDouble(Console.ReadLine()));
        }
        public static void Main(string[] args)
        {
            Console.Write("please input the coordinate x1:");
            double x1 = read();
            Console.Write("please input the coordinate y1:");
            double y1 = read();
            Console.Write("please input the coordinate x2:");
            double x2 =read();
            Console.Write("please input the coordinate y2:");
            double y2 = read();
            double d = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            Console.WriteLine("the distance beteew the piont 1 and 2 is {0}", d);
        }
    }
}
