using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs._11_dziedziczenie
{
    class DomAzurowy : Domek
    {

        private int _iloscOkien;

        public int IloscOkien { get => _iloscOkien; set => _iloscOkien = value; }

        public override void sprawdzIloscOkien()
        {
            Console.WriteLine("Ilosc okien : " + IloscOkien);
        }

        public override void ustawIloscOkien()
        { 
            IloscOkien = int.Parse(Console.ReadLine());
        }
        
    }
}
