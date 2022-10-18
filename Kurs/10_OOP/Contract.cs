using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs._10_OOP
{
    class Contract
    {
        private double _salary;

        public Contract() { }

        public Contract(double _salary)
        {
            this._salary = _salary;   
        }

        public double salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

     

    }
}
