using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a number of finding its factorial: ");
            int a=Convert.ToInt32(Console.ReadLine());
            double b=Math.Sqrt(1.0*a);
            int j=0;
            Console.WriteLine("the factorial by using increment counter:");
            for(int i=2;i<=b;i++)
            {
                if(a%i==0)
                {
                    Console.WriteLine(i);
                    j=1;
                    }
            }
            if(j==0)
                Console.WriteLine("no factorial ");
            Console.WriteLine("the factorial by using decrement counter:");
            for(int i=Convert.ToInt32(b-b%1);i>1;i--)
            { 
                if(a%i==0)
                {
                    Console.WriteLine(i);
                    j=1;
                    }
            }
            if(j==0)
                Console.WriteLine("no factorial ");
        }
    }
}
