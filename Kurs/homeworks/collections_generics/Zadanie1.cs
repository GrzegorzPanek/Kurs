using System;
using System.Collections;

namespace Kurs.homeworks
{
    public class Zadanie1
    {
        public void hashTableHomework()
        {
            Hashtable homework = new Hashtable();
            ArrayList temp = new ArrayList();
            Stack stack = new Stack();

            for (int i = 0; homework.Count < 10; i++)
            {

                Console.WriteLine("Podaj klucz: ");
                String key = Console.ReadLine();
                Console.WriteLine("Podaj wartość (liczby): ");
                int value = int.Parse(Console.ReadLine());
                Console.Clear();
                homework[key] = value;
            }

            PrintIndexAndKeysAndValues(homework);

            foreach (var item in homework.Values)
            {
                Console.WriteLine("Dodany: " + item);
                stack.Push(item);
            }

            while (stack.Count > 0)
            {
                temp.Add(stack.Pop());
            }

            foreach (var item in temp)
            {
                Console.WriteLine("\n" + item + " do kwadratu: " + Math.Pow((int)item, 2));
            }
            Console.ReadKey();
        }

        public static void PrintIndexAndKeysAndValues(Hashtable myHT)
        {
            int i = 0;
            Console.WriteLine("\t-INDEX-\t-KEY-\t-VALUE-");
            foreach (DictionaryEntry de in myHT)
                Console.WriteLine($"\t[{i++}]:\t{de.Key}\t{de.Value}");
            Console.WriteLine();
        }
    }
}
