using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string b = Console.ReadLine();
            int a = 0;
            int e = 0;
            int i = 0;
            int o = 0;
            int u = 0;
            for (int j = 0; j < b.Length; j++)
            {
                if (b.Substring(j, 1) == "a")
                    a++;
                else if (b.Substring(j, 1) == "e")
                    e++;
                else if (b.Substring(j, 1) == "i")
                    i++;
                else if (b.Substring(j, 1) == "o")
                    o++;
                else if (b.Substring(j, 1) == "u")
                    u++;                
            }
            Console.WriteLine("Toatl number of wovowels: {5}\nNumber of a: {0} \nNumber of e: {1} \nNumber of i: {2} \nNumber of o: {3} \nNumber of u: {4} \n",a,e,i,o,u,a+e+i+o+u);
        }
    }
}
