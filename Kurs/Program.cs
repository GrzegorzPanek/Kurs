using Kurs.homeworks.algorytmy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Kurs
{
    class Program
    {

        static void Main(string[] args)
        {
           IloscSlowCiag ciag = new IloscSlowCiag();
            ciag.AnalizaTekstu("Ala ma kota i kot ma ale");

            TabliczkaMnozenia tabliczka = new TabliczkaMnozenia();
            tabliczka.drukujTabliczke();
        }

       public static void Rec(int a)
        {
            if(a > 0)
            {
                Console.WriteLine("{0}", a);
                Rec(a - 1);
                Console.WriteLine("{0}", a);
            }
            else
            {
                Console.WriteLine("finished");
            }
        }
    }
}






