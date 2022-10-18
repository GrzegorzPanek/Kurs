using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.homeworks
{
    class Rownanie
    {
        //static void Main(string[] args)
        //{
        //    Stopwatch stopWatch = new Stopwatch();
        //    stopWatch.Start();

        //    Random random = new Random();
        //    bool powtorzenie = true;
        //    int wynik = 0;
        //    int wynik2 = 0;
        //    int iloscRozwiazan = 0;

        //    string[] numery = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };


        //    while (powtorzenie)
        //    {
        //        int index = random.Next(numery.Length);
        //        int index2 = random.Next(numery.Length);
        //        int index3 = random.Next(numery.Length);
        //        int index4 = random.Next(numery.Length);
        //        int index5 = random.Next(numery.Length);
        //        int index6 = random.Next(numery.Length);

        //        string wyrazPom2 = numery[index2];
        //        string wyrazPom3 = numery[index3];
        //        string wyrazPom4 = numery[index4];
        //        string wyrazPom5 = numery[index5];

        //        string wyraz1 = numery[index];
        //        string wyraz2 = numery[index2] + numery[index3];
        //        string wyraz3 = numery[index4] + numery[index5];
        //        string wyraz4 = numery[index6];


        //        if (wyraz2.Contains(wyraz1) || wyraz2.Contains(wyraz4) || wyraz3.Contains(wyraz1) || wyraz3.Contains(wyraz4))
        //        {
        //            Console.WriteLine("Powtórzenie.");
        //        }
        //        else
        //        {
        //            if (index2 == index3 || index2 == index4 || index2 == index5 || index3 == index4 || index3 == index5)
        //            {
        //                Console.WriteLine("Powtórzenie");
        //            }
        //            else
        //            {
        //                wynik = convertToInt(wyraz1) * convertToInt(wyraz2);
        //                wynik2 = convertToInt(wyraz3) * convertToInt(wyraz4);

        //                if ((wynik > 100 && wynik < 1000) && (wynik2 > 100 && wynik < 1000))
        //                {
        //                    string wyrazWynik = wynik.ToString();

        //                    if (wyrazWynik[0].ToString() == wyrazWynik[1].ToString() || wyrazWynik[0].ToString() == wyrazWynik[2].ToString() || wyrazWynik[1].ToString() == wyrazWynik[2].ToString() ||
        //                    wyrazWynik.Contains(wyraz1) || wyrazWynik.Contains(wyrazPom2) || wyrazWynik.Contains(wyrazPom3) || wyrazWynik.Contains(wyrazPom4) || wyrazWynik.Contains(wyrazPom5) || wyrazWynik.Contains("0"))
        //                    {
        //                        Console.WriteLine("Powtórzenie.");
        //                    }
        //                    else
        //                    {
        //                        wynik = convertToInt(wyraz1) * convertToInt(wyraz2);
        //                        wynik2 = convertToInt(wyraz3) * convertToInt(wyraz4);
        //                        if (wynik2 == wynik)
        //                        {
        //                            if (wyrazWynik[0].ToString() == wyrazWynik[1].ToString() || wyrazWynik[0].ToString() == wyrazWynik[2].ToString() || wyrazWynik[1].ToString() == wyrazWynik[2].ToString() ||
        //                            wyrazWynik.Contains(wyraz4) || wyrazWynik.Contains(wyrazPom4) || wyrazWynik.Contains(wyrazPom5) || wyrazWynik.Contains("0"))
        //                            {
        //                                Console.WriteLine("Powtórzenie.");
        //                            }
        //                            else
        //                            {
        //                                Console.Clear();
        //                                iloscRozwiazan++;
        //                                Console.WriteLine("rozwiązanie " + iloscRozwiazan + "\n");
        //                                powtorzenie = false;
        //                                Console.Write("Równanie\n\n{0} * {1} = {2} = {4} * {3}", wyraz1, wyraz2, wynik, wyraz4, wyraz3);
        //                                Console.ReadKey();
        //                            }
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine("Powtórzenie.");
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Wynik mniejszy od 100.");
        //                }
        //            }
        //        }
        //    }

        //    stopWatch.Stop();
        //    TimeSpan ts = stopWatch.Elapsed;

        //    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
        //        ts.Hours, ts.Minutes, ts.Seconds,
        //        ts.Milliseconds);
        //    Console.WriteLine("\n\nRunTime " + elapsedTime + "\n\n");
        //    Console.ReadKey();
        //}

        //public static int convertToInt(string liczba)
        //{
        //    return int.Parse(liczba);
        //}
    }
}
