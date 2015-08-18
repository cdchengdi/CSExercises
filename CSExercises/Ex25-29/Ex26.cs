using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("{0,-18}{1,-18}{2,-18}{3,-18}","NO","INVERSE","SQUARE ROOT","SQUARE");
            for (int i = 1; i < 18*4; i++)
                Console.Write("-");
            Console.WriteLine();
            for (int i = 1; i < 11; i++)
                Console.WriteLine("{0,-18:0.0}{1,-18:0.###}{2,-18:0.0##}{3,-18:0.0}",i,1/(1.0*i),Math.Sqrt(1.0*i),i*i);
        }
    }
}
