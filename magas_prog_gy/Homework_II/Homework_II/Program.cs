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
            } while(!uint.TryParse(Console.ReadLine(), out chickenBreastPrice) || chickenBreastPrice == 0 || chickenBreastPrice % 5 != 0);

            do
            {
                Console.WriteLine("How many kilograms do you buy?");
            } while(!float.TryParse(Console.ReadLine(), out amount) || amount < 0);

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

            //Console.WriteLine(chickenBreastPrice);

            //byte byteN = 255;
            //short shortN = 255;
            //int intN = 255;
            //int sum = byteN + shortN;
            //Console.WriteLine(sum);



            Console.WriteLine("\nTask 2");
            //Írj olyan programot, amely először bekér egy x pozitív egész számot.
            //Ezek után létrehoz egy 100 - elemű tömböt és feltölti azt véletlen egész számokkal az[x, 3x] intervallumból.
            //Határozd meg, hogy hány db. 2x - nél kisebb szám szerepel a tömbben és írd is ki őket a képernyőre!
            //Fontos: beolvasásnál kezeld a parse-olási hibákat és az értékhibákat is !


            uint myNumber;
            do
            {
                Console.WriteLine("Enter a positive intiger!");
            } while(!uint.TryParse(Console.ReadLine(),out myNumber) || myNumber == 0);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            uint[] randomsArr = new uint[100];
            var elapsedMs = watch.ElapsedMilliseconds;
            Random rnd = new Random();
            foreach(uint random in randomsArr )
            {
                rnd.Next((int)myNumber, (int)myNumber * 3);
            }



            Console.ReadLine();
        }
    }
}