
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VS21._1._1
{
    class Program
    {
        static int[,] land;
        static int x;
        static int y;
        static void Gardener1()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (land[i, j] == 0)
                    {
                        land[i, j] = 1;
                    }
                    Thread.Sleep(10);
                }
            }
        }

        static void Gardener2()
        {
            for (int i = y - 1; i > 0; i--)
            {
                for (int j = x - 1; j > 0; j--)
                {
                    if (land[j, i] == 0)
                    {
                        land[j, i] = 2;
                    }
                    Thread.Sleep(10);
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Ввести значение х");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввести значение у");
            y = Convert.ToInt32(Console.ReadLine());
            land = new int[x, y];
            Thread gard1 = new Thread(Gardener1);
            Thread gard2 = new Thread(Gardener2);
            gard1.Start();
            gard2.Start();
            gard1.Join();
            gard2.Join();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(land[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }

}

