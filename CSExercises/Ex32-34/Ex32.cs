using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int min = 0;
            int max=0;
            double sum = 0;
            int[] A = new int[12];
            for (int i = 0; i < 12; i++)
            {
                Console.Write("Enter sales for month {0}: ", i);
                A[i] = Convert.ToInt32(Console.ReadLine());
                max=A[max]>A[i]?max:i;
                min=A[min]<A[i]?min:i;
                sum += A[i];

            }
            Console.WriteLine("Maximum Sales: {0}\nMinimun Sales: {1}\nAverage Sales: {2}",max,min,sum/12);
        }
    }
}
