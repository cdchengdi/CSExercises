using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] a = { { 56, 84, 68, 29 }, { 94, 73, 31, 89 }, { 41, 63, 36, 90 }, { 99, 9, 18, 17 }, { 62, 3, 65, 75 }, { 40, 96, 53, 23 }, 
                       { 81, 15, 27, 30 }, { 21, 70, 100, 22 }, { 88, 50, 13, 12 }, { 48, 54, 52, 78 }, { 64, 71, 67, 25 }, { 16, 93, 46, 72 } };
            int SUM=0;
            for (int i = 0; i < 12; i++)
            {
                int sum = 0;
                for (int j = 0; j < 4; j++)
                {
                    sum += a[i, j];
                    SUM += a[i, j];
                    
                }
                Console.WriteLine("student {0}'s total marks are {1}", i, sum);
            }
            for (int j = 0; j < 4; j++)
            {
                int sum = 0;
                double d=0;
                for (int i = 0; i < 12; i++)             
                    sum += a[i, j];
                for (int i = 0; i < 12; i++)
                    d += (sum / 12 - a[i, j]) * (sum / 12 - a[i, j]);
                Console.WriteLine("the standard deviation of subject {0} is {1}", j, d / 12);
            }
            Console.WriteLine("the average of whole marks are {0}",SUM/(12*4));
        }
    }
}
