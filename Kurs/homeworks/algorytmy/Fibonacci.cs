using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.homeworks.algorytmy
{
    class Fibonacci
    {
        public double countFibonacci(double n)
        {
            {
                int suma = 0;

                if (n <= 2)
                {
                    return 1;
                }
                else
                {
                    int b = 1;
                    int c = 1;

                    for (int i = 3; i <= n; i++)
                    {
                        suma = b + c;
                        Console.WriteLine(i + " wyraz ciągu = " + suma);
                        b = c;
                        c = suma;
                    }
                    Console.WriteLine();
                    return suma;
                }
            }
        }
    }
}
