using System;

namespace Kurs.homeworks.oop
{
    public class Stal
    {
        private string _skladChemiczny;
        private string _stopienCzystosci;
        private string _nazwa;
        private int _id;

        public Stal() { }

        public Stal(string _skladChemiczny, string _stopienCzystosci, string _nazwa)
        {
            this._skladChemiczny = _skladChemiczny;
            this._stopienCzystosci = _stopienCzystosci;
            this._nazwa = _nazwa;
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string nazwa
        {
            get => _nazwa;
            set { _nazwa = value; }
        }

        public string stopienCzystosci
        {
            get
            {
                if (_stopienCzystosci == "zwykly" || _stopienCzystosci == "wyzszy" || _stopienCzystosci == "najwyzszy")
                {

                    return _stopienCzystosci;
                }

                return "Stal moze miec 3 stopnie czystosci";
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (Convert.ToInt32(char.ToLower(value[i])) >= 97 && Convert.ToInt32(char.ToLower(value[i])) <= 122)
                        _stopienCzystosci += value[i];
                }
            }
        }

        public string skladChemiczny
        {
            get
            {
                if (_skladChemiczny == "weglowa" || _skladChemiczny == "stopowa")
                {
                    return _skladChemiczny;
                }
                return "Stal moze miec 3 stopnie czystosci";
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (Convert.ToInt32(char.ToLower(value[i])) >= 97 && Convert.ToInt32(char.ToLower(value[i])) <= 122)
                        _skladChemiczny += value[i];
                }
                //if(value == "zwykły")
                //{

                //}
            }
        }
    }

}
