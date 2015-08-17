using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex16
    {
        private static string G( string a )
        {
            if (a == "M")
                return "Mr.";
            else
                return "Ms.";
        }
        public static void Main(string[] args)
        {
            Console.Write("Please input your name: ");
            string name=Console.ReadLine();
            Console.Write("Please input your gender: ");
            String gender=Console.ReadLine();
            Console.WriteLine("Good Morning {0} {1}",G(gender),name);
        }
    }
}