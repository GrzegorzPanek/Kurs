using System;
using System.Collections.Generic;
using System.Linq;

namespace Kurs.homeworks.oop
{
    public class Hurtownia
    {
        private string _jakosc;

        private HashSet<Stal> _sklad = new HashSet<Stal>();

        public Stal stal = new Stal();

        public Hurtownia() { }

        public Hurtownia(string _jakosc)
        {
            this._jakosc = _jakosc;
        }

        public HashSet<Stal> sklad
        {
            get { return _sklad; }
            set { _sklad = value; }
        }


        public string jakosc
        {
            get => _jakosc;
            set
            {
                if (value == "niska" || value == "dobra" || value == "super")
                {
                    _jakosc = value;
                }
                else
                {
                    Console.WriteLine("\nHurtownia moze miec 3 stopnie jakości.");
                }
            }
        }

        public void addToSklad(Stal stal)
        {

            if ((stal.stopienCzystosci == "zwykly" || stal.stopienCzystosci == "wyzszy" || stal.stopienCzystosci == "najwyzszy") 
                && (stal.skladChemiczny == "weglowa" || stal.skladChemiczny == "stopowa"))
            {
                _sklad.Add(stal);
            }
            else
            {
                Console.WriteLine("\n Nie dodano do listy\n");
            }
        }

        public void removeFromSklad(Stal stal)
        {
            _sklad.Remove(stal);
            Console.WriteLine("Towar o id = " + stal.id + " został usuniety.");
        }

        public void printSuperStal()
        {
            Console.WriteLine("Hurtownia SUPER stali\n ".ToUpper());
            listIsEmpty();
            int number = 1;
            foreach (Stal item in _sklad)
            {
                if (item.skladChemiczny == "stopowa" && item.stopienCzystosci == "najwyzszy")
                {
                    Console.WriteLine("{0} STAL {1}\n \n[skład] : {2} \n[stopień czystości] : {3} \n[id]: {4}\n", number, item.nazwa.ToUpper(), item.skladChemiczny, item.stopienCzystosci, item.id);
                    number++;
                }
            }
        }

        public void printDobraStal()
        {
            Console.WriteLine("Hurtownia Dobrej stali\n ".ToUpper());
            listIsEmpty();
            int number = 1;
            foreach (Stal item in _sklad)
            {
                if ((item.skladChemiczny == "stopowa" && item.stopienCzystosci == "wyzszy") || item.skladChemiczny == "weglowa"
                    && (item.stopienCzystosci == "wyzszy" || item.stopienCzystosci == "najwyzszy"))
                {
                    Console.WriteLine("{0} STAL {1}\n \n[skład] : {2} \n[stopień czystości] : {3} \n[id]: {4}\n", number, item.nazwa.ToUpper(), item.skladChemiczny, item.stopienCzystosci, item.id);
                    number++;
                }
            }
        }

        public void drukujSlabaStal()
        {
            Console.WriteLine("Hurtownia niskiej jakosci stali\n ".ToUpper());
            listIsEmpty();
            int number = 1;
            foreach (Stal item in _sklad)
            {
                if ((item.skladChemiczny == "weglowa" || item.skladChemiczny == "stopowa") && item.stopienCzystosci == "zwykly")
                {
                    Console.WriteLine("{0} STAL {1}\n \n[skład] : {2} \n[stopień czystości] : {3} \n[id]: {4}\n", number, item.nazwa.ToUpper(), item.skladChemiczny, item.stopienCzystosci, item.id);
                    number++;
                }
            }
        }

        public void printSklad()
        {
            listIsEmpty();
            foreach (Stal item in _sklad)
            {
                Console.WriteLine("{0}. {1}{2}  \n[skład]: {3} \n[stopień czystości]: {4}\n", item.id, "Stal ".ToUpper(), item.nazwa.ToUpper(), item.skladChemiczny, item.stopienCzystosci);
            }

        }

        public bool listIsEmpty()
        {
            bool isEmpty = !_sklad.Any();
            if (isEmpty)
            {
                Console.WriteLine("Hurtownia jest pusta.\n");
                return true;
            }
            return false;
        }

        public bool czyTowaryDodany()
        {
            bool isEmpty = _sklad.Any();
            if (isEmpty)
            {
                Console.WriteLine("Towary zostały dodane.\n");
                return true;
            }
            return false;
        }
    }
}
