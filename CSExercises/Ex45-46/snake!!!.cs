using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    class snake!!
    {
        public static void Main(string[] args)
        {
            int[,] sl = { { 1, 38 }, { 4, 18 }, { 9, 31 }, { 28, 84 }, { 21, 42 }, { 71, 91 }, { 80, 100 }, { 51, 67 }, { 17, 7 }, { 54, 34 }, { 87, 24 }, { 64, 60 }, { 95, 75 }, { 93, 73 }, { 98, 79 } };
            Console.Write("Enter the number of player: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string[] name = new string[a];
            int[] number = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.Write("enter the name of player {0}: ", i);
                name[i] = Console.ReadLine();
                number[i] = 1;
            }
            Random r = new Random();
            int j = 0;
            do
            {

                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine("{0,-5} is at  {1}, press enter to run the dice...", name[i], number[i]);
                    string e = Console.ReadLine();
                    int k = r.Next(1, 7);
                    number[i] += k;
                    Console.WriteLine("the dice is {0}, {1,-10} is now at {2}", k, name[i], number[i]);
                    if (number[i] >= 100)
                    {
                        Console.WriteLine("{1} is the winner!!!!!"); 
                        j = 1;
                        break;                       
                    }
                    for (int h = 0; h < sl.GetLength(0); h++)
                        if (number[i] == sl[h, 0])
                        {
                            number[i] = sl[h, 1];
                            if (sl[h, 0] < sl[h, 1])
                                Console.WriteLine("Oh Yeah! It's a ladder, {0,-5} is at {1}", name[i], number[i]);
                            else
                                Console.WriteLine("Oh No! It's a snake, {0,-5} is at {1}", name[i], number[i]);
                        }
                } 
            } while (j == 0);
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine(); 
            Console.ReadLine(); 
            Console.ReadLine();

        }
    }
}
