using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.homeworks.algorytmy
{
    class Fizz
    {

        public void fizzBuzz()
        {
            Enumerable.Range(1, 100).Select(x =>
            {
                var str = "";
                if (x % 3 == 0)
                {
                    str += "Fizz";
                }
                if (x % 5 == 0)
                {
                    str += "Buzz";
                }
                if (str == "")
                {
                    str = x.ToString();
                }
                return str;
            }).ToList().ForEach(Console.WriteLine);
        }
    }
}
