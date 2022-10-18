using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.homeworks.algorytmy
{
    class ChristmasTree
    {
        public void printTree()
        {
            Console.WriteLine("Podaj wysokość choinki: ");
            try
            {
                int n = int.Parse(Console.ReadLine());

                string a = "*";
                string b = " ";
                int d = n;

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j < d; j++)
                    {
                        Console.Write(b);
                    }
                    for (int p = 1; p <= i; p++)
                    {
                        Console.Write(a);
                    }
                    for (int k = 1; k <= i - 1; k++)
                    {
                        Console.Write(a);
                    }
                    d--;
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Niepoprawny format danych. ");
            }
        }

        public void krecha()
        {
            Console.WriteLine("============================");
        }


    }
}
