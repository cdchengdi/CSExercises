using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("output the Perfect Number: ");
          for (int i = 5; i < 1001; i++)
          {
              int k = 0;
              int b = 1;
              for (int j = 2; b < i; j++)
              {
                  b *= j;
                  if (b == i)
                      k = 1;
              }
              if (k == 1)
                  Console.WriteLine(i);
          }
        }
    }
}
