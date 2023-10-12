using System.Security.Claims;
using System.Text;

namespace Homework_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Egy áruházláncnak írunk szoftvert.

            //Kérd be először, hogy mennyibe kerül 1 kg akciós csirkemell! Az érték 5 - tel osztható kell legyen!

            //Utána kérd be, hogy a felhasználó hány kg - ot vásárol ebből a termékből. (Ez az érték akár valós szám is lehet.)

            //Ezek után számold ki és jelenítsd meg, mennyibe kerül mindez a felhasználónak.

            //Minden elköltött 10.000 Ft után jár a vásárlónak 1 db.mütyür, de maximum 5 db.Határozd meg,
            //hogy a felhasználónak mennyi mütyür jár, majd írd ki a következőket:

            //  "Nem jár mütyür": Ha 0 db.jár neki.
            //  "A maximális mennyiségű mütyürt kapod": Ha 5.db - ot kap.
            //  "x db. mütyür jár": Egyébként az x helyébe helyettesítsd be a megfelelő értéket.
            //Fontos: beolvasásnál kezeld a parse-olási hibákat és az értékhibákat is (pl.ár és tömeg negatív nem lehet)!

            uint chickenBreastPrice = 0;
            float amount;
            do
            {
                Console.WriteLine("How much does 1 kg of discounted chicken breast cost?");
            } while (!uint.TryParse(Console.ReadLine(), out chickenBreastPrice) || chickenBreastPrice == 0 || chickenBreastPrice % 5 != 0);

            do
            {
                Console.WriteLine("How many kilograms do you buy?");
            } while (!float.TryParse(Console.ReadLine(), out amount) || amount < 0);

            float price = amount * chickenBreastPrice;
            Console.WriteLine($"This is going to cost you {price} Ft");
            //byte mutyurCount = 0;
            if (price < 10000)
            {
                Console.WriteLine("Nem jár mütyür");
            }
            else if (price / 10000 >= 5)
            {
                Console.WriteLine("A maximális mennyiségű mütyürt kapod");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(price / 10000)} db. mütyür jár");
            }

            Console.WriteLine(chickenBreastPrice);




            Console.WriteLine("\nTask 2");
            //Írj olyan programot, amely először bekér egy x pozitív egész számot.
            //Ezek után létrehoz egy 100 - elemű tömböt és feltölti azt véletlen egész számokkal az[x, 3x] intervallumból.
            //Határozd meg, hogy hány db. 2x - nél kisebb szám szerepel a tömbben és írd is ki őket a képernyőre!
            //Fontos: beolvasásnál kezeld a parse-olási hibákat és az értékhibákat is !

            uint myNumber;
            do
            {
                Console.WriteLine("Enter a positive intiger!");
            } while (!uint.TryParse(Console.ReadLine(), out myNumber) || myNumber == 0);

            //var watch = System.Diagnostics.Stopwatch.StartNew();
            uint[] randomsArr = new uint[100];
            //var elapsedMs1 = watch.ElapsedMilliseconds;
            //Console.WriteLine($"Array declaration: {elapsedMs1}");
            Random rnd = new Random();
            int counter = 0;
            for (int i = 0; i < randomsArr.Length; i++)
            {
                randomsArr[i] = (uint)rnd.Next((int)myNumber, (int)myNumber * 3 + 1);
                if (randomsArr[i] < myNumber * 2)
                {
                    counter++;
                    Console.WriteLine(randomsArr[i]);
                }
            }
            Console.WriteLine($"There are {counter} numbers that are lower than 2 × myNumber.");
            //var elapsedMs2 = watch.ElapsedMilliseconds;
            //Console.WriteLine($"Array filled with random values in: {elapsedMs2} ms");



            //int myNumber;
            //do
            //{
            //    Console.WriteLine("Enter a positive intiger!");
            //} while (!int.TryParse(Console.ReadLine(), out myNumber) || myNumber == 0);

            //var watch = System.Diagnostics.Stopwatch.StartNew();
            //int[] randomsArr = new int[1000000000];
            //var elapsedMs1 = watch.ElapsedMilliseconds;
            //Console.WriteLine($"Array declaration: {elapsedMs1}");
            //Random rnd = new Random();
            //for (int i = 0; i < randomsArr.Length; i++)
            //{
            //    randomsArr[i] = rnd.Next(myNumber, myNumber * 3);
            //}
            //var elapsedMs2 = watch.ElapsedMilliseconds;
            //Console.WriteLine($"Array filled with random values in: {elapsedMs2} ms");



            Console.WriteLine("\nTask 3");
            //Írj programot, mely először bekéri az aktuális évet(pl. 2023).
            //Ezek után bekéri akármennyi ember születési évét, egészen addig, a felhasználó egy 'X' - et nem ír be helyette.
            //Minden születési év esetén ellenőrizze, hogy az az aktuális évnél nem nagyobb - e, mert ha igen, azt nem szabad figyelembe venni.
            //Miután 'X' - szel megszakítottuk az adatbekérést, a program írja ki:

            //a legkorábbi születési évet
            //a legkésőbbi születési évet
            //az átlagos életkort

            List<ushort> birthYears = new List<ushort>();
            ushort currentYear;
            do
            {
                Console.WriteLine("Enter the current year!");
            } while (!ushort.TryParse(Console.ReadLine(), out currentYear));

            ushort oneBirthYear;
            string line;
            do
            {
                Console.WriteLine("Enter a person's birth year! (Enter 'X' to stop)");
                line = Console.ReadLine();
                if (ushort.TryParse(line, out oneBirthYear) && oneBirthYear <= currentYear)
                {
                    birthYears.Add(oneBirthYear);
                }
            } while (line != "X");

            ushort earliestBirthYear = birthYears[0];
            ushort latestBirthYear = birthYears[0];
            int sumAge = 0;
            foreach (ushort birthYear in birthYears)
            {
                //Console.WriteLine(birthYear);
                if (birthYear < earliestBirthYear)
                {
                    earliestBirthYear = birthYear;
                }
                if (birthYear > latestBirthYear)
                {
                    latestBirthYear = birthYear;
                }
                sumAge += (int)birthYear;
            }
            Console.WriteLine($"The earliest year of birth is: {earliestBirthYear}");
            Console.WriteLine($"The latest year of birth is: {latestBirthYear}");
            Console.WriteLine($"The average age is: {sumAge / birthYears.Count}");



            Console.ReadLine();
        }
    }
}