using System;

namespace Kurs.homeworks.collections_generics
{
    class Zadanie2
    {

        public void genericMethod<T, P>(T first, P second)
        {
            Console.WriteLine("s1: " + first + ", s2: " + second);

        }

        public int inputX()
        {
            Console.WriteLine("Wprowadz liczbe: ");
            int x =  int.Parse(Console.ReadLine());
            Console.Clear();
            return x;
        }

        public String inputY()
        {
            Console.WriteLine("Wprowadz wyraz: ");
            String y = Console.ReadLine();
            Console.Clear();
            return y;
        }
    }
}
