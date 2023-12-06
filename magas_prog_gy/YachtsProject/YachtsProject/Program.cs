using System.Reflection;
using System;

namespace YachtsProject
{
    //Készíts programot egy gazdag oligarcha jachtflottájának nyilvántartására! Minden jachtról 2 adatot tárolunk:
    //  a modell nevét(pl.Azimut Grande 32M) és az árát millió dollárban(pl. 8,83).

    //A program egy ciklusban működik, és ehhez megjelenít egy menüt:
    //  V: Jacht vásárlása
    //  A: Jacht eladása
    //  D: Legdrágább jacht
    //  Esc: Kilépés
    //Ez a ciklus addig fut, amíg Esc-et nem nyom a felhasználó.

    //A menüelemek működése:

    //V: Az "adatbázisban" levő jachtok mellé felveszünk egy újat.Ehhez kérd be először a jachtmodell nevét,
    //  majd ellenőrizd le, hogy van-e már ilyen modell a flottában; ehhez a lenti metódust hívd majd meg!
    //  Ha nincs még ilyen jacht, akkor bekérjük az új jacht másik adatát is, majd letároljuk az új jacht adatait az "adatbázisban".
    // A meghívandó metódus legyen a következő: kereses(jachtok, modellNev)
    // Ez keresse meg az adott modellű jachtot a listában és ha megtalálja, adja vissza annak listabeli indexét; ha nem találja meg, akkor -1-et!

    //A: Az "adatbázisból" törlünk egy jachtot.Ehhez kérd be először a jachtmodell nevét, majd ellenőrizd le, hogy van-e ilyen modell a flottában;
    //  ehhez a fenti metódust hívd meg! Ha van ilyen jacht, akkor töröljük az "adatbázisból".

    //D: Megkeresi a flotta legdrágább jachtját és kiírja mindkét adatát a képernyőre.Ehhez írd meg és használd a következő metódust:
    //maxKereses(jachtok)
    //A metódus visszaadja a legdrágább jacht indexét.

    //Az egész feladatot egészítsd még ki az oligarcha vagyonának nyilvántartásával is, a következőképpen:
    //A program legelején kérd be és tárold le az oligarcha összvagyonát millió dollárban!
    //A V menüpontban vizsgáld meg, hogy az oligarchának van-e egyáltalán elegendő pénze az adott jachtra!
    //Ha nincs, akkor ne engedd megvenni neki! Ha van, akkor pedig vond le a vagyonából a jacht árát!
    //Az A menüpontban add hozzá az oligarcha vagyonához az eladott jacht árát!
    //Javaslatok a program elkészítéséhez: Mérlegeld, van-e szükség tömbre/listára! Ha igen, akkor mérlegeld, hogy melyikre! Törekedj alprogramok(eljárások és függvények) írására! Próbáld takarékosan megválasztani a típusokat! Mindig kezeld a felhasználó hülyeségét!
    
    internal class Program
    {
        static float oligarchsWealth;
        static List<Yacht> yachts = new List<Yacht>();

        static int kereses(List<Yacht> yachts, string yachtModel)
        {
            for (int i = 0; i < yachts.Count; i++)
            {
                if (yachts[i].Model == yachtModel)
                {
                    return i;
                }
            }
            return -1;
        }

        static int maxKereses(List<Yacht> yachts)
        {
            if (yachts.Count == 0)
            {
                return -1;
            }
            int mostExpensiveIndex = 0;
            for (int i = 1; i < yachts.Count; i++)
            {
                if (yachts[i].Price > yachts[mostExpensiveIndex].Price)
                {
                    mostExpensiveIndex = i;
                }
            }
            return mostExpensiveIndex;
        }

        static void VProcess()
        {
            string yachtModel;
            do
            {
                Console.WriteLine("Add meg a várásolni kívánt jachtmodell nevét!");
                yachtModel = Console.ReadLine();
            } while (yachtModel.Length == 0);
            
            if (kereses(yachts, yachtModel) == -1)
            {
                float yachtPrice;
                do
                {
                    Console.WriteLine("Add meg a jacht árát millió dollárban! (pl: 11.2)");
                } while (!float.TryParse(Console.ReadLine(), out yachtPrice) || yachtPrice < 0);
                if (oligarchsWealth - yachtPrice < 0)
                {
                    Console.WriteLine("Az oligarchának nincs elég vagyona megvenni ezt a jachtot.");
                    return;
                }
                oligarchsWealth -= yachtPrice;
                yachts.Add(new Yacht(yachtModel, yachtPrice));
                Console.WriteLine("Jacht sikeresen megvásárolva.");
            }
            else
            {
                Console.WriteLine("Az oligarcha flottájában már van ilyen típusú jacht!");
            }
        }

        static void DProcess()
        {
            if (yachts.Count == 0)
            {
                Console.WriteLine("Az oligarcha flottája nem létezik.");
                return;
            }
            Console.WriteLine(yachts[maxKereses(yachts)].ToString());
        }

        static void AProcess()
        {
            if (yachts.Count == 0)
            {
                Console.WriteLine("Az oligarcha flottája nem létezik.");
                return;
            }
            Console.WriteLine("Add meg az eladni kívánt jachtmodell nevét!");
            string yachtModel = Console.ReadLine();
            int keresesResult = kereses(yachts, yachtModel);
            if (keresesResult != -1)
            {
                oligarchsWealth += yachts[keresesResult].Price;
                yachts.RemoveAt(keresesResult);
                Console.WriteLine("Jacht sikeresen eladva.");
            }
            else
            {
                Console.WriteLine("Ilyen modellű jacht nincs az oligarcha flottájában!");
            }

        }


        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Add meg az oligarcha vagyonát millió dollárban! (pl 115.83)");
            } while (!float.TryParse(Console.ReadLine(), out oligarchsWealth) || oligarchsWealth < 0);

            ConsoleKey key;
            do
            {
                Console.WriteLine("\nAz alábbi billentyűk lenyomásával választhatsz a menüpontok közül!");
                Console.WriteLine("\tV: Jacht vásárlása");
                Console.WriteLine("\tA: Jacht eladása");
                Console.WriteLine("\tD: Legdrágább jacht");
                Console.WriteLine("\tEsc: Kilépés");
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.V:
                        VProcess();
                        break;
                    case ConsoleKey.A:
                        AProcess();
                        break;
                    case ConsoleKey.D:
                        DProcess();
                        break;
                    case ConsoleKey.Escape:
                        break;
                    default:
                        Console.WriteLine("\nNem megfelelő billentyűt nyomtál!");
                        break;
                }

            } while (key != ConsoleKey.Escape);
        }
    }
}