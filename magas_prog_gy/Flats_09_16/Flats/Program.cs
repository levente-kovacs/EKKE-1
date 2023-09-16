// See https://aka.ms/new-console-template for more information
string address1;
string address2;

do
{
    Console.WriteLine("Add meg az 1. lakás címét!");
    address1 = Console.ReadLine();
} while (address1.Length > 5);

do
{
    Console.WriteLine("Add meg az 2. lakás címét!");
    address2 = Console.ReadLine();
} while (address2.Length > 5);


float area1;
float area2;
do
{
    Console.WriteLine($"Add meg a(z) {address1} cím alatti lakás területét (m2-ben)!");

} while (!float.TryParse(Console.ReadLine(), out area1) || area1 < 1);

do
{
    Console.WriteLine($"Add meg a(z) {address2} cím alatti lakás területét (m2-ben)!");

} while (!float.TryParse(Console.ReadLine(), out area2) || area2 < 1);


int price;
do
{
    Console.WriteLine($"Add meg a négyzetméter árat (Ft)!");

} while (!int.TryParse(Console.ReadLine(), out price) || area2 <= 0);


int flat1Price = (int)Math.Round(area1 * price);
int flat2Price = (int)Math.Round(area2 * price);

if (flat1Price > 40000000 && flat2Price > 40000000)
{
    Console.WriteLine("Tök mindegy, melyik drágább, úgysem tudom megvenni.");
}
else if (flat1Price == flat2Price)
{
    Console.WriteLine($"A(z) {address1} és a(z) {address2} alatti lakások ugyanannyiba kerülnek.");
}
else
{
    if (flat1Price > flat2Price)
    {
        Console.WriteLine($"A(z) {address1} alatti lakás drágább, mint a(z) {address2} alatti lakás.");
    }
    else
    {
        Console.WriteLine($"A(z) {address2} alatti lakás drágább, mint a(z) {address1} alatti lakás.");
    }
}




Console.WriteLine("Nyomj le egy billentyűt...");
Console.ReadKey();