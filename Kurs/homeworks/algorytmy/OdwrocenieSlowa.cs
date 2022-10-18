using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.homeworks.algorytmy
{
    internal class OdwrocenieSlowa
    {
        public void odwrocSlowa()
        {
            var words = "foo bar foobar    one two";
            Console.WriteLine(string.Join(" ", words.Split(' ').Where(x => !String.IsNullOrEmpty(x)).Reverse()));
        }
    }
}
