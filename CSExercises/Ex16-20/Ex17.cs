using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex17
    {
        static int read()
        {
            return (Convert.ToInt32(Console.ReadLine()));
        }
        private static string G(string a, int b)
        {
            if (a == "M")
            {
                if (b < 40)
                    return "Mr.";
                else
                    return "Uncle";
            }
            else
            {
                if (b < 40)
                    return "Ms.";
                else
                    return "Aunty";
            }
        }
        public static void Main(string[] args)
        {
            Console.Write("Please input your name: ");
            string name = Console.ReadLine();
            Console.Write("Please input your gender: ");
            String gender = Console.ReadLine();
            Console.Write("Please input your age: ");
            int age = read();
            Console.WriteLine("Good Morning {0} {1}", G(gender,age), name);   
        }
    }
}