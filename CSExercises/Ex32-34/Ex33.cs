using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] a = { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            for (int i = 0; i < 20; i++)
                for (int j = i + 1; j < 20; j++)
                    if (a[i] < a[j])
                    {
                        int t=a[i];
                        a[i]=a[j];
                        a[j]=t;
                    }
            for (int i = 0; i < 20; i++)
                Console.Write("{0}\t",a[i]);
        }
    }
}
