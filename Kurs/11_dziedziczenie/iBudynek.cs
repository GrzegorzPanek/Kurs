using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs._11_dziedziczenie
{
    interface iBudynek
    {
        string drzwiWejsciowe { get; set; }
        void zamknijDrzwiWejsciowe();
        void otworzDrzwiWejsciowe();
        void sprawdzStanDrzwiWejsciowych();

    }
}
