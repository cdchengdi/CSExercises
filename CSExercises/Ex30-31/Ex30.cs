using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("output the Prime Number: ");
            for (int i = 5; i < 1001; i++)
            {
                int k = 0;
                for (int j = 2; j<=Math.Sqrt(1.0 * i); j++)
                {
                    
                    if (i % j == 0)
                    {
                        k = 1;
                        break;
                    }
                    
                }          
                if (k == 0)
                    Console.WriteLine(i);     
            }
        }
    }
}
