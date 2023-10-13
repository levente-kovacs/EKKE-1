//Kérd be Magyarország lakosságszámát.
//Utána kérd be, hogy a mai napon az elvégzett COVID-tesztek hány százaléka volt pozitív (pl. 23,54%), és írd ki,
//    hogy ezzel kalkulálva kb. hány ember COVID-pozitív ma Magyarországon.
//Utána kérd be, hogy hány COVID-fertőzött hunyt el a mai napon, és írd ki, hogy ez hány százaléka a COVID-pozitívok (becsült) számának.
//Fontos: kezeld a parse-olási hibákat és az értékhibákat is (pl. százalékérték csak 0 és 100 közé eshet).
Console.WriteLine("Task 1");
uint hungarysPopulation;
do
{
    Console.WriteLine("Enter Hungary's population!");
} while (!uint.TryParse(Console.ReadLine(), out hungarysPopulation));

float covidPositivePercent;
do
{
    Console.WriteLine("Enter what percentage of covid tests performed today were positive!");
} while (!float.TryParse(Console.ReadLine(), out covidPositivePercent) || !(covidPositivePercent >= 0 && covidPositivePercent <= 100));

float covidPositiveCount = hungarysPopulation * covidPositivePercent / 100;
Console.WriteLine($"There are about {covidPositiveCount} covid positive people today in Hungary.");

uint peopleDiedInCovid;
do
{
    Console.WriteLine("Enter how many people died today in covid!");
} while (!uint.TryParse(Console.ReadLine(), out peopleDiedInCovid) || !(peopleDiedInCovid <= hungarysPopulation));
Console.WriteLine($"About {peopleDiedInCovid / covidPositiveCount * 100}% of covid positive people died today.");


Console.WriteLine("\nTask 2");
//Egy 25-elemű vektort tölts fel véletlen értékekkel (10-80 közötti számokkal)!
//Határozd meg a tömbelemek átlagát, és hogy hány olyan szám van, amelyik ezen átlagérték 90%-ától kisebb vagy 110%-ától nagyobb!
//Sorold is fel ezeket a számokat!
byte[] randomArr = new byte[25];
Random rnd = new Random();
int sum = 0;
for (int i = 0; i < randomArr.Length; i++)
{
    randomArr[i] = (byte)rnd.Next(10, 81);
    sum += randomArr[i];
}
float avgOfArr = sum / (float)randomArr.Length;
Console.WriteLine($"The average of the array is: {avgOfArr}");

int counter = 0;
for (int i = 0; i < randomArr.Length; i++)
{
    if (randomArr[i] < avgOfArr * 0.9)
    {
        counter++;
        Console.WriteLine(randomArr[i]);
    }
    if (randomArr[i] > avgOfArr * 1.1)
    {
        counter++;
        Console.WriteLine(randomArr[i]);
    }
}
Console.WriteLine($"There are {counter} numbers, amelyik ezen átlagérték 90%-ától kisebb vagy 110%-ától nagyobb!");


Console.WriteLine("\nTask 3");
//Kérd be egy hallgató nevét.
//Utána kérd meg a hallgatót, hogy írja be a Magasprog1 vizsgajegyeit.
//(Mivel 1-es esetén vizsgát kell ismételni, illetve javítóvizsgát is tehet, így előre nem tudjuk, hány darab jegyet fog beírni.)
//A jegyek bekérése két okból állhat le:
//Már 5 db. 1-est szerzett. Ekkor a Tanulmányi és Vizsgaszabályzat alapján nem vizsgázhat többé.
//Megszerzi az első 5-ösét. (Ezt már biztos nem akarja javítani egy újabb vizsgán.)
//Beírja(a jegy bekérésekor), hogy "ELÉG".
//Ezek után írjuk ki a következőket:
//Hányszor vizsgázott összesen.
//Hány 1-est és hány nem 1-est szerzett.
//Mennyi a jegyei átlaga.
Console.Write("Add meg a neved: ");
string name = Console.ReadLine();
string line;
byte oneMagasprog1Grade;
List<byte> magasprog1ExamGrades = new List<byte>();
byte grade1Counter = 0;
do
{
    Console.WriteLine("Add meg a Magasprog1 vizsgajegyeid!");
    line = Console.ReadLine();
    if (byte.TryParse(line, out oneMagasprog1Grade) && oneMagasprog1Grade >= 1 && oneMagasprog1Grade <= 5)
    {
        magasprog1ExamGrades.Add(oneMagasprog1Grade);
        if (oneMagasprog1Grade == 1)
        {
            grade1Counter++;
        }
    }
} while (!(line == "ELÉG" || grade1Counter == 5 || oneMagasprog1Grade == 5));

int sum2 = 0;
foreach (var magasprog1Grade in magasprog1ExamGrades)
{
    sum2 += magasprog1Grade;
    //Console.WriteLine(magasprog1Grade);
}
Console.WriteLine($"{name} összesen {magasprog1ExamGrades.Count}x vizsgázott.");
Console.WriteLine($"{name} {grade1Counter} egyest szerzett.");
Console.WriteLine($"{name} {magasprog1ExamGrades.Count - grade1Counter} nem egyest szerzett.");
Console.WriteLine($"{name} jegyeinek átlaga {sum2 / (float)magasprog1ExamGrades.Count}.");




Console.ReadKey();
