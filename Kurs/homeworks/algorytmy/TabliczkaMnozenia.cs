using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.homeworks.algorytmy
{
    internal class TabliczkaMnozenia
    {
        public void drukujTabliczke()
        {

            int [] tab1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] tab2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

           

            foreach (int item in tab1)
            {
                foreach (int item2 in tab2)
                {
                    Console.Write((item * item2) + "\t");
                }
                Console.WriteLine("\n");
            }
           
        }
    }
}
