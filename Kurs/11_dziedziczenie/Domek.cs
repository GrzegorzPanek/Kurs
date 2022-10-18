using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs._11_dziedziczenie
{
    abstract class Domek : iBudynek
    {
        public abstract void ustawIloscOkien();
        public abstract void sprawdzIloscOkien();


        public Domek()
        { }
        private string _stan_drzwi_wejsciowe;

        public string drzwiWejsciowe
        {
            get
            {
                return _stan_drzwi_wejsciowe;
            }
            set
            {
                if (value == "otwarte" || value == "zamkniete")
                {
                    _stan_drzwi_wejsciowe = value;
                }

            }
        }
        public void zamknijDrzwiWejsciowe()
        {
            drzwiWejsciowe = "zamkniete";
        }
        public void otworzDrzwiWejsciowe()
        {
            drzwiWejsciowe = "otwarte";
        }
        public void sprawdzStanDrzwiWejsciowych()
        {
            Console.WriteLine("Stan drzwi wej: " + drzwiWejsciowe);
        }
    }
}
