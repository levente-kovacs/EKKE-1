using Pools;

Pool GetPoolData()
{
    double poolR;
    double poolH;
    do
    {
        Console.Write("Enter the radius of the pool: ");
    } while (!double.TryParse(Console.ReadLine(), out poolR) || poolR < 1);

    do
    {
        Console.Write("Enter the height of the pool: ");
    } while (!double.TryParse(Console.ReadLine(), out poolH) || poolH < 1);

    Pool pool = new Pool(poolR, poolH);
    return pool;
}

Console.WriteLine("First pool");
Pool pool1 = GetPoolData();
double pool1Volume = pool1.CalcVolume();
Console.WriteLine($"The first pool can hold up to {pool1Volume} m3 water.");

Console.WriteLine("\nSecond pool");
Pool pool2 = GetPoolData();
double pool2Volume = pool2.CalcVolume();
Console.WriteLine($"The second pool can hold up to {pool2Volume} m3 of water.");

Console.WriteLine();
if (pool1Volume > pool2Volume)
{
    Console.WriteLine($"\nBuy the pool with {pool1}.");
}
else if (pool1Volume < pool2Volume)
{
    Console.WriteLine($"\nBuy the pool with {pool2}.");
}
else
{
    Console.WriteLine($"No matter which pool you buy, both can store {pool1Volume} m3 of water");
}


Console.ReadKey();
