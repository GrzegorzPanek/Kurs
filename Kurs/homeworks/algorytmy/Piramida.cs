using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.homeworks.algorytmy
{
    internal class Piramida
    {

        public int CountElements(int n)
        {
            int suma = 0;

            for(int i = 1; i <= n; i++)
            {
                int temp = n * n;
                suma = suma + temp;
                n--;
            }
            int koncowa = suma + 1;
            Console.WriteLine(koncowa);
            return koncowa;
        }


    }
}
