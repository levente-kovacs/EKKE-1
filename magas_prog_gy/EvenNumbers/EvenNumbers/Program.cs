// See https://aka.ms/new-console-template for more information

int count;

do
{
    Console.WriteLine("Hány darab számot szeretnél beolvastatni?");
} while (!int.TryParse(Console.ReadLine(), out count) || count <= 0);

List<int> numbers = new List<int>();

{
    int currentNumber;
    for (int i = 0; i < count; i++)
    {
        do
        {
            Console.WriteLine($"Add meg a(z) {i + 1}. számot!");
        } while (!int.TryParse(Console.ReadLine(), out currentNumber) || !(currentNumber > -2000 && currentNumber < 2000) || !(currentNumber % 2 == 0));
        numbers.Add(currentNumber);
    }
}

Console.WriteLine($"\nA megadott számok összege: {numbers.Sum()}");
Console.WriteLine($"A megadott számok átlaga: {numbers.Average()}");

Console.WriteLine("Nyomj le egy billentyűt a kilépéshez....");
Console.ReadKey();
