using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex43
    {
        public static string Hex(int i)
        {
            string h = "";
            double a = Math.Log(i) / Math.Log(16);
            int j = Convert.ToInt32(a - a % 1);
            if (i % Convert.ToInt32(Math.Pow(16, j)) == 0&&j>0)
            {
                h = "1";
                for (int k = 0; k < j; k++)
                    h += "0";
                return h;
            }
            else
            {
                for (int k = j; j > 0; j--)
                {
                    int b = i / Convert.ToInt32(Math.Pow(16, j));
                    i -=  i /Convert.ToInt32(Math.Pow(16, j)) * Convert.ToInt32(Math.Pow(16, j));
                    h += RE(b);
                }
                h += RE(i);
                return h;
            }
        }
        public static string RE(int i)
        {
            switch (i)
            {
                case 0:
                    return "0";
                    break;
                case 1:
                    return "1";
                    break;
                case 2:
                    return "2";
                    break;
                case 3:
                    return "3";
                    break;
                case 4:
                    return "4";
                    break;
                case 5:
                    return "5";
                    break;
                case 6:
                    return "6";
                    break;
                case 7:
                    return "7";
                    break;
                case 8:
                    return "8";
                    break;
                case 9:
                    return "9";
                    break;
                case 10:
                    return "A";
                    break;
                case 11:
                    return "B";
                    break;
                case 12:
                    return "C";
                    break;
                case 13:
                    return "D";
                    break;
                case 14:
                    return "E";
                    break;
                case 15:
                    return "F";
                    break;
                default:
                    return "";
                    break;
            }
        }       
        public static void Main()
        {

            for (int i = 1; i < 101;i++ )
                Console.WriteLine(Hex(i));
        }
    }
}
