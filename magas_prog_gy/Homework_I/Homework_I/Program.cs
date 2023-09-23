//  Az alábbi feladatokban a felhasználótól addig kérd be újra és újra az inputokat, amíg azok meg nem felelnek a megadott feltételeknek!

//  10. Kérj be egy x pozitív egész számot! Utána kérj be egy sztinget, amelynek a hossza legalább x!
Console.WriteLine("10. feladat");
int x;
string myString = "";

do
{
    Console.WriteLine("Add meg a szöveg mininális hosszát!");
} while (!int.TryParse(Console.ReadLine(), out x) || x <= 0);

do
{
    Console.WriteLine("Add meg a szöveget, mely hossza legalább az imént megadott szám!");
    myString = Console.ReadLine();
} while (myString.Length < x);


//  11. Kérj be egy x pozitív egész számot! Utána kérj be egy x-szel osztható számot!
Console.WriteLine("\n11. feladat");
int x2;
int y2;

do
{
    Console.WriteLine("Adj meg egy pozitív egész számot!");
} while (!int.TryParse(Console.ReadLine(), out x2) || x2 <= 0);

do
{
    Console.WriteLine("Adj meg egy számot, amely osztható az előző számmal!");
} while (!int.TryParse(Console.ReadLine(), out y2) || y2 % x2 != 0);


//  13. Kérj be egy s nem üres sztringet! Utána kérj be egy olyan sztringet, amely hosszabb s-nél!
Console.WriteLine("\n13. feladat");
string s;
string longerThanS;

do
{
    Console.WriteLine("Adj meg egy nem üres stringet!");
    s = Console.ReadLine();
} while (s.Length <= 0);

do
{
    Console.WriteLine("Adj meg egy szöveget, amely hosszabb az előzőnél!");
    longerThanS = Console.ReadLine();
} while (longerThanS.Length <= s.Length);


//  14. Kérj be egy x lebegőpontos számot! Utána kérj be egy olyan y lebegőpontos számot, hogy |x−y|≥1!
Console.WriteLine("\n14. feladat");
double x3;
double y3;

do
{
    Console.WriteLine("Adj meg egy x lebegőpontos számot!");
} while (!double.TryParse(Console.ReadLine(), out x3));

do
{
    Console.WriteLine("Adj meg egy olyan y lebegőpontos számot, melyre teljesül, hogy |x−y|>=1!");
} while (!double.TryParse(Console.ReadLine(), out y3) || Math.Abs(x3 - y3) < 1);


//  15. Kérj be egy x egész nemnegatív számot, utána pedig egy nála nagyobb y egész számot!
//      Végül kérj be egy olyan sztringet, melynek a hossza az [x,y] intervallumba esik!
Console.WriteLine("\n15. feladat");
int x4;
int y4;
string s2;

do
{
    Console.WriteLine("Adj meg egy x egész nemnegatív számot!");
} while(!int.TryParse(Console.ReadLine(), out x4) || x4 < 0);

do
{
    Console.WriteLine("Adj meg egy y, előzőnél nagyobb egész számot!");
} while(!int.TryParse(Console.ReadLine(), out y4) || y4 <= x4);

do
{
    Console.WriteLine("Adj meg egy szöveget, mely hossza az [x,y] intervallumba esik!");
    s2 = Console.ReadLine();
} while(s2.Length < x4 || s2.Length > y4);


Console.ReadKey();