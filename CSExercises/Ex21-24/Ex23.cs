using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex23
    {
        private static string text(int a)
        {
            if (a < 3)
                return "You are a Wizard!";
            else if (a < 6)
                return "You are a good guess";
            else
                return "You are lousy!";
        }
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 9);
            Console.Write("please input the number you guess: ");
            int b =  Convert.ToInt32(Console.ReadLine());
            int i;
            for (i=1;  b != a;b = Convert.ToInt32(Console.ReadLine()))
            {
                Console.Write("Try again: ");
                i++;
            }
            Console.WriteLine(text(i));
        }
    }
}
