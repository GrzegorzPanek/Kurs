using System;

namespace Kurs.homeworks.oop
{
    class Instruction
    {
        public void printMenu()
        {
            Console.WriteLine("\n[1] Wyświetl towary na składzie hurtowni.");
            Console.WriteLine("[2] Wyświetl towary na skladzie hurtowni niskej jakosci stali.");
            Console.WriteLine("[3] Wyświetl towary na skladzie hurtowni dobrej jakosci stali.");
            Console.WriteLine("[4] Wyświetl towary na skladzie hurtowni super jakosci stali.");
            Console.WriteLine("[5] Dodaj towar do hurtowni.");
            Console.WriteLine("[6] Usuń towar z hurtowni.");
            Console.WriteLine("[7] Powrót do menu.");
            Console.WriteLine("[8] Wyjdz z hurtowni.");

        }

        public void switchToMenu()
        {
            Console.WriteLine("\n[7] powrót do menu głównego. ");
        }

    }

    //public void play()
    //{
    //    Console.WriteLine("Witamy w hurtowni stali. WYbierz numer wewnętrzny.\n");

    //    Instruction interaction = new Instruction();
    //    interaction.printMenu();
    //    int select = 0;

    //    Hurtownia hurtownia = new Hurtownia();

    //    Stal stal1 = new Stal("weglowa", "zwykly", "szybkotnaca") { id = 1 };
    //    Stal stal2 = new Stal("weglowa", "wyzszy", "narzędziowa") { id = 2 };
    //    Stal stal3 = new Stal("stopowa", "najwyzszy", "nierdzewma") { id = 3 };
    //    Stal stal4 = new Stal("stopowa", "najwyzszy", "meteorytowa") { id = 4 };
    //    Stal stal5 = new Stal("weglowa", "najwyzszy", "konstrukcyjna") { id = 5 };
    //    Stal stal6 = new Stal("weglowa", "najwyzszy", "kwasoodporna") { id = 6 };
    //    Stal stal7 = new Stal("stopowa", "zwykly", "zyletkowa") { id = 7 };

    //    do
    //    {
    //        try
    //        {
    //            Console.WriteLine("\n");
    //            select = int.Parse(Console.ReadLine());

    //            Console.Clear();

    //            if (select > 0 && select < 9)
    //            {
    //                switch (select)
    //                {
    //                    case 1:
    //                        Console.Clear();
    //                        Console.WriteLine("Na skladzie hurtowni znajduję się: \n");
    //                        hurtownia.printSklad();
    //                        interaction.switchToMenu();
    //                        break;

    //                    case 2:
    //                        hurtownia.drukujSlabaStal();
    //                        interaction.switchToMenu();
    //                        break;

    //                    case 3:
    //                        hurtownia.printDobraStal();
    //                        interaction.switchToMenu();
    //                        break;

    //                    case 4:
    //                        hurtownia.printSuperStal();
    //                        interaction.switchToMenu();
    //                        break;

    //                    case 5:
    //                        //Console.WriteLine("Dodaj stal do skladu.");
    //                        //Stal staltest = new Stal(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()) {id = int.Parse(Console.ReadLine())};
    //                        //hurtownia.addToSklad(staltest);
    //                        hurtownia.addToSklad(stal1);
    //                        hurtownia.addToSklad(stal2);
    //                        hurtownia.addToSklad(stal3);
    //                        hurtownia.addToSklad(stal4);
    //                        hurtownia.addToSklad(stal5);
    //                        hurtownia.addToSklad(stal6);
    //                        hurtownia.addToSklad(stal7);
    //                        hurtownia.czyTowaryDodany();
    //                        interaction.switchToMenu();
    //                        break;

    //                    case 6:
    //                        hurtownia.removeFromSklad(stal4);
    //                        hurtownia.removeFromSklad(stal1);
    //                        interaction.switchToMenu();
    //                        break;

    //                    case 7:
    //                        interaction.printMenu();
    //                        break;

    //                    case 8:
    //                        Console.Clear();
    //                        Console.WriteLine("Do zobaczenia!");
    //                        Environment.Exit(0);
    //                        break;
    //                }
    //            }
    //            else
    //            {
    //                Console.WriteLine("Musisz wybrać liczbę od 1 do 8 \n");

    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Console.Clear();
    //            Console.WriteLine(e + "Wprowadzono niepoprawne dane. Wybierz ponownie. ");
    //        }

    //    } while (select != 0);
}





