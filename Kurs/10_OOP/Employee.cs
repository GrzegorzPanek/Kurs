using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//utwórz podstawy systemu zarz¹dzania pracownikami w pewnej firmie. zaimplementuj klasê 
//reprezentuj¹c¹ pracownika.
//ka¿dy pracownik opisany jest w³aœciwoœciami:
//    imiê i nazwisko
//    kontrakt
//klasa reprezentuj¹ca pracownika udostêpnia operacje:
//    konstruktor inicjuj¹cy pracownika o podanym w argumentach imieniu i nazwisku z domyœlnym 
//    kontraktem sta¿ysty
//    metodê pozwalaj¹c¹ zmieniæ kontrakt przypisany do pracownika
//    metoda zwracaj¹ca wysokoœæ pensji pracownika uzale¿nionej od podpisanego kontraktu
//    doci¹¿on¹ metodê tostring() zwieraj¹c¹ ³añcuch znakowy zawieraj¹cy imiê, nazwisko i 
//    wysokoœæ pensji pracownika
//ka¿dy kontrakt reprezentowany jest przez obiekt udostêpniaj¹cy publicznie nastêpuj¹ce operacje:
//    metodê o nazwie pensja(), która zwraca wysokoœæ pensji wyp³acanej przy danym kontrakcie.
//    konstruktor pozwalaj¹cy zainicjowaæ wszystkie pola sk³adowe obiektu
//    konstruktor domyœlny
//obecnie w firmie podpisywane s¹ 2 rodzaje kontraktów: sta

namespace Kurs._10_OOP
{
    class Employee
    {
        private string _name;
        private string _surname;
        private int _age;

        Contract contract = new Contract();
        
        public string name
        {
            get { return _name; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (Convert.ToInt32(char.ToLower(value[i])) >= 97 && Convert.ToInt32(char.ToLower(value[i])) <= 122)
                        _name += value[i];
                }
            }
        }

        public string surname
        {
            get { return _surname;}
            set {
                for (int i = 0; i < value.Length; i++)
                {
                    if (Convert.ToInt32(char.ToLower(value[i])) >= 97 && Convert.ToInt32(char.ToLower(value[i])) <= 122)
                        _surname += value[i];
                }
            }
        }

        public int age
        {
            get { return _age;}
            set { _age = value;
            }
        }

        
       public Employee(string _name, string _surname, int _age, Contract contract)
        {
            this._name = _name;
            this._surname = _surname;
            this._age = _age;
           this.contract = contract;
            
        }

        public Employee()
        {
        }

       

       
    }
}
