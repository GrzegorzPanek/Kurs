using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.homeworks.algorytmy
{
    internal class IloscSlowCiag
    {

        public void AnalizaTekstu(string text)
        {
           
            int suma = 0;
            foreach (var item in SplitToWords(text))
            {
                Console.WriteLine(item + "\t");
                suma++;
                
            }
            Console.WriteLine("\nIlosc wyrazow w ciagu " + suma);

            int min = SplitToWords(text).Select(x => x.Length).Min();
            Console.WriteLine("\nNajkrotsze slowo w ciagu ma " + min + " wyrazy.");

            var sorted = SplitToWords(text).OrderBy(n => n.Length);
            var shortest = sorted.FirstOrDefault();
            var longest = sorted.LastOrDefault();

            Console.WriteLine("\nNajkrótsze słowo : " + shortest + "\nNajdłuższe słowo : " + longest + "\n");
        }

        public static List<string> SplitToWords(string text)
        {
            List<string> words = new List<string>();
            words = text.Split(' ').ToList();
            
            return words;
        }

        

        static String minWord = "", maxWord = "";

        static void minMaxLengthWords(String input)
        {
            // minWord and maxWord are received by reference
            // and not by value
            // will be used to store and return output
            int len = input.Length;
            int si = 0, ei = 0;
            int min_length = len, min_start_index = 0,
                max_length = 0, max_start_index = 0;

            // Loop while input string is not empty
            while (ei <= len)
            {
                if (ei < len && input[ei] != ' ')
                {
                    ei++;
                }
                else
                {
                    // end of a word
                    // find curr word length
                    int curr_length = ei - si;

                    if (curr_length < min_length)
                    {
                        min_length = curr_length;
                        min_start_index = si;
                    }

                    if (curr_length > max_length)
                    {
                        max_length = curr_length;
                        max_start_index = si;
                    }
                    ei++;
                    si = ei;
                }
            }

            // store minimum and maximum length words
            minWord = input.Substring(min_start_index, min_length);
            maxWord = input.Substring(max_start_index, max_length);
        }

    }
}
