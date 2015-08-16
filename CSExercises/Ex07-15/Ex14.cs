using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace CSExercises
{
    public class Ex14
    {
        static double read()
        {
            return (Convert.ToDouble(Console.ReadLine()));
        }
        public static void Main(string[] args)
        {
            Console.Write("please input the triangle's side a:");
            double a = read();
            Console.Write("please input the triangle's side b:");
            double b = read();
            Console.Write("please input the triangle's side c:");
            double c = read(); 
            double s=(a+b+c)/2;
            if ((s > a) && (s > b) && (s > c))
                Console.WriteLine("The area of triangle is{0}", Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
            else
                Console.WriteLine("input error!!");
        }
    }
}