using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("{0,-12}{1,-12}","X","Y");
            for (int j = 1; j < 24; j++)
                Console.Write("-");
            Console.WriteLine();
            int i = 0;
            double[] Y=new double[51];
            double max = 0;
            for (double x = -5; x <= 5.01; x+=0.2)
            {               
                Y[i] = 2 * x * x - 4 * x + 3;              
                Console.WriteLine("{0,-12:.0}{1,-12:.0}",x,Y[i]);
                max=max>Y[i]?max:Y[i];
                i++;
            }
            Console.WriteLine("\n\n\n");
            for (int k = Convert.ToInt32(max); k >= 0; k--)
            {
                string y="";
                if (k % 5 == 0||k==0)
                    y = Convert.ToString(k);
                Console.Write("{0,-6}", y);
                for (int l = 0; l < 51; l++)
                {
                    if (Y[l] < k)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Write("\n{0,-6}","");

            for (int x = -5; x <= 5; x++)
            { 
                Console.Write("{0,-5}", x);
            }

        }
    }
}
