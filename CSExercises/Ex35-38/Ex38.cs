using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex38
    {
        static void report(string[] a, int[] b)
        {
            Console.WriteLine("Name\t\tMark");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("{0}\t\t{1}", a[i], b[i]);
            }
        }
        public static void Main(string[] args)
        {
            string[] name = { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = { 63, 29, 75, 82, 55 };
            for (int i = 0; i < mark.Length; i++)
                for (int j = i+1;j< mark.Length;j++)
                {
                    if (mark[i] < mark[j])
                    {
                        int t = mark[i];
                        mark[i] = mark[j];
                        mark[j] = t;
                        string tt=name[i];
                        name[i] = name[j];
                        name[j] = tt;
                    }
                }
            report(name, mark);
            Console.WriteLine("\n\n");
            for (int i = 0; i < mark.Length; i++)
                for (int j = i+1;j< mark.Length;j++)
                {
                    if (name[i].CompareTo(name[j])==1)
                    {
                        int t = mark[i];
                        mark[i] = mark[j];
                        mark[j] = t;
                        string tt=name[i];
                        name[i] = name[j];
                        name[j] = tt;
                    }
                } 
            report(name, mark);
        }
       
    }
}
