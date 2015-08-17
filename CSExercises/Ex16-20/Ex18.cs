using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex18
    {
        static int read()
        {
            return (Convert.ToInt32(Console.ReadLine()));
        }
        private static string G(int a)
        {
            if (a < 0 || a > 100)
                return "**Error**";
            else
            {
                if (a >= 80)
                    return "A";
                else
                {
                    if (a >= 60)
                        return "B";
                    else
                    {
                        if (a >= 40)
                            return "C";
                        else
                            return "F";
                    }
                }
            }

        }
 
        public static void Main(string[] args)
        {
            Console.Write("Please input your score: ");
            int score = read();
            Console.WriteLine("Your scored {0} marks which is {1}",score,G(score));
        }
    }
}