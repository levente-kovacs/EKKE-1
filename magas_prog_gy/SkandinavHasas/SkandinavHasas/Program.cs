//3.Feladat.A skandináv hasas-ugrás világbajnokságon minden versenyző 5 db értékelést
//kap, melyek mindegyike 0.00 és 5.00 közé esik. Az Ön feladata a verseny eredményét tároló
//és azt elemző program elkészítse el az alábbiak szerint!

namespace SkandinavHasas
{
    internal class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //a) Kérje be a felhasználótól, hogy hány versenyző indult! Amennyiben 3-nál kevesebb,
            //úgy adjon hibaüzenetet, majd Enter lenyomása után állítsa le a programot!
            int competitorCount;
            do
            {
                Console.WriteLine("Enter the count of competitors: ");
            } while (!int.TryParse(Console.ReadLine(), out competitorCount));
            if (competitorCount < 3)
            {
                Console.WriteLine("Too few competitors.");
            } else
            {
                //b) Hozzon létre egy akkora valós értékű tömböt, melyben elfér minden versenyző mind
                //az 5 db értékelése!
                float[] competitors = new float[competitorCount * 5];

                //c) Töltse fel a tömböt 2 tizedesjegy pontosságú véletlen értékekkel a [0, 5] intervallum -
                //ból! Tekintse ezeket a számokat úgy, mint az egyes versenyzők sorfolytonosan tárolt
                //eredményeit! Például:
                for (int i = 0; i < competitors.Length; i++)
                {
                    competitors[i] = (float)(rnd.Next(501) / 100.0);
                }

                //d) Határozza meg az egyes versenyzők átlagos pontszámát és írja ki a képernyőre!
                int competitorIndex = 0;
                int maxCompetitorIndex = 0;
                int maxAvgScoreIndex = 0;
                float maxScore = 0;
                float maxAvgScore = 0;
                for (int i = 0; i < competitors.Length; i+=5)
                {
                    float sumScore = 0;
                    float avgScore;
                    bool isLame = true;
                    for (int j = i; j < i + 5; j++)
                    {
                        //Console.WriteLine(competitors[j]);
                        sumScore += competitors[j];

                        if (competitors[j] > maxScore)
                        {
                            maxScore = competitors[j];
                            maxCompetitorIndex = competitorIndex;
                        }

                        if (competitors[j] > 2.00)
                        {
                            isLame = false;
                        }
                    }
                    avgScore = (float)(sumScore / 5.0);
                    Console.WriteLine($"The {competitorIndex+1}. competitor's average score is: {avgScore}");

                    //f) Egy versenyző béna, ha csak 2.00 alatti értékelései vannak. Minden versenyzőről
                    //döntse el, hogy béna-e, vagy sem, majd jelenítse meg az eredményt a képernyőn!
                    if (isLame)
                    {
                        Console.WriteLine($"The {competitorIndex+1}. competitor is lame.\n");
                    }
                    else
                    {
                        Console.WriteLine($"The {competitorIndex+1}. competitor is not lame.\n");
                    }

                    if (avgScore > maxAvgScore)
                    {
                        maxAvgScore = avgScore;
                        maxAvgScoreIndex = competitorIndex;
                    }
                    competitorIndex++;
                }

                string s = "asd";
                //e) Határozza meg, hogy melyik versenyző kapta a legmagasabb pontszámú (nem át-
                //lagos) értékelést és írja ki a képernyőre a versenyző sorszámát, valamint az elért
                //pontszámot!
                Console.WriteLine($"The {maxCompetitorIndex + 1}. competitor recieved the highest score: {maxScore}");

                //g) A versenyt az az ugró nyeri, akinek a legmagasabb az átlagos értékelése. Határozza
                //meg, hogy melyik ugró, milyen átlagos pontszámmal nyerte a versenyt! Feltételez-
                //heti, hogy bármely két versenyzőnek különbözik az átlagos értékelése!
                Console.WriteLine($"The {maxAvgScoreIndex + 1}. competitor won the competition with an average score of {maxAvgScore}");
            }
        }
    }
}