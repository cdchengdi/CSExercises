using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
             int[] a ={0,0,0,0,0,0,0,0,0,0};
            Random r= new Random();
            for (int i = 0; i < 50; i++)
            {                
                int k=r.Next(0,10);
                a[k]++;
            }
            Console.WriteLine("{0,-8}{1,-8}","Number","Count");
            for (int i = 0; i < 10; i++)
                Console.WriteLine("{0,-8}{1,-8}",i,a[i]);
            Console.WriteLine("Number");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0,-6}",i);
                for (int j = 0; j < a[i]; j++)
                    Console.Write("*");
                Console.WriteLine();
            }            
            int[] b = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Random R = new Random();
            for (int i = 0; i < 100; i++)
            {
                int k = R.Next(-5, 5);
                if (i <= 50)
                    b[k + 5]++;
            }
        }
    }
}
