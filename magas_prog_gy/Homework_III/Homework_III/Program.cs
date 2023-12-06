using static System.Net.WebRequestMethods;
using System.Collections.Generic;

namespace Homework_III
{
    public class Program
    {
//      12. Írj egy függvényt, amely 2 listát kap: városnevek listáját és a hozzájuk tartozó lakosságszámok listáját.
//          A függvényt válogassa ki és adja vissza azokat a városneveket, amelyben 100.000-nél többen laknak!
        public static List<string> GetMoreLargestCities(List<string> cityNames, List<int> populations)
        {
            List<string> largestCityNames = new List<string>();
            if (cityNames.Count != populations.Count)
            {
                largestCityNames.Add("Error.");
            }
            for (int i = 0; i < populations.Count; i++)
            {
                if (populations[i] > 100000)
                {
                    largestCityNames.Add(cityNames[i]);
                }
            }
            return largestCityNames;
        }


//      13. Írj egy függvényt, amely kap egy int listát és két egész számot (x és y)!
//          A függvény válogassa ki és adja vissza azokat a listaelemeket, melyek értékben x és y közé esnek!
        static List<int> IntsBetween(List<int> ints, int x, int y)
        {
            List<int> intsBetween = new List<int>();
            foreach (int i in ints)
            {
                if (i > Math.Min(x, y) && i < Math.Max(x, y))
                {
                    intsBetween.Add(i);
                }
            }
            return intsBetween;
        }


//      14. Írj egy függvényt, amely 3 listát kap, melyekben autók 3-3 összetartozó adata található:
//          autó rendszámtáblája, életkora években és fogyasztása literben.
//          A függvény válogassa ki azoknak az autóknak a rendszámtábláit,
//          melyeket legalább 12 évesek és a fogyasztásuk nagyobb, mint 10 liter!
        static List<string> FilterCars(List<string> registrationNumbers, List<byte> ages, List<byte> consumptions)
        {
            List<string> filteredRegNums = new List<string>();
            for (int i = 0; i <= registrationNumbers.Count; i++)
            {
                if (ages[i] >= 12 && consumptions[i] > 10)
                {
                    filteredRegNums.Add(registrationNumbers[i]);
                }
            }
            return filteredRegNums;
        }


        //      15. Írj egy függvényt, amely 3 listát kap, melyekben személyek 3-3 összetartozó adata található:
        //      személy neve, testmagassága m-ben és testsúlya kg-ban.
        //      A függvény válogassa ki azoknak a neveit, akik túlsúlyosak, azaz a testtömegindexük nagyobb, mint 30!
        //      A testtömegindex így számolható ki: https://hu.wikipedia.org/wiki/Testt%C3%B6megindex
        static List<string> FilterPeople(List<string> names, List<byte> heights, List<byte> weights)
        {
            List<string> overWeightPpls = new List<string>();
            for (int i = 0; i <= names.Count; i++)
            {
                if ((weights[i] / (float)(heights[i] * heights[i])) > 30)
                {
                    overWeightPpls.Add(names[i]);
                }
            }
            return overWeightPpls;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}