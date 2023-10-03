List<int> GenerateRandomColorCode()
{
    List<int> colorCode = new List<int>();
    for (int i = 0; i < 3; i++)
    {
        Random rnd = new Random();
        colorCode.Add(rnd.Next(255));
    }
    return colorCode;
}

List<int> colorCode = new List<int>();
bool codeOk = false;
do
{
    Console.Write("Enter an RGB color code (e.g. 255 255 255): ");
    string[] stringParts = Console.ReadLine().Split(' ');
    if (stringParts.Length == 3)
    {
        colorCode.Clear();
        int stringPartInt;
        for (int i = 0; i < stringParts.Length; i++)
        {
            if(int.TryParse(stringParts[i], out stringPartInt))
            {
                if (stringPartInt >= 0 && stringPartInt <= 255)
                {
                    colorCode.Add(stringPartInt);
                }
                else
                {
                    break;
                }
            }
            else
            {
                break;
            }
        }
        if (colorCode.Count == 3)
        {
            codeOk = true;
        }
    }
} while(!codeOk);

void CheckColor(string color, int code1, int code2, int code3)
{
    Console.Write($"{color}\t");
    if (colorCode[0] == code1 && colorCode[1] == code2 && colorCode[2] == code3)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

void WriteWithColor(string colorName, ConsoleColor consoleColor)
{
    Console.ForegroundColor = consoleColor;
    Console.Write(colorName);
    Console.ForegroundColor = ConsoleColor.White;

}

void CheckClosestColor(List<int> colorCode, string title)
{
    Console.Write($"The closest primary color to the {title} is:");
    if (colorCode.Max() == colorCode[0])
    {
        WriteWithColor(" Red", ConsoleColor.Red);
    }
    if (colorCode.Max() == colorCode[1])
    {
        WriteWithColor(" Green", ConsoleColor.Green);
    }
    if (colorCode.Max() == colorCode[2])
    {
        WriteWithColor(" Blue", ConsoleColor.Blue);
    }
    Console.WriteLine();
}

string ConvertToHex(List<int> colorCode)
{
    return $"{colorCode[0]:X2}{colorCode[1]:X2}{colorCode[2]:X2}";
}

string ShortenHexCode(string hexCode)
{
    if (hexCode.Distinct().Count() == 1)
    {
        return hexCode[..3];
    }
    return hexCode;
}

Console.WriteLine($"\nYour RGB color in HEX code is: #{ShortenHexCode(ConvertToHex(colorCode))}");
Console.WriteLine("Your color is:");
CheckColor("Red", 255, 0, 0);
CheckColor("Green", 0, 255, 0);
CheckColor("Blue", 0, 0, 255);
CheckColor("White", 255, 255, 255);
CheckColor("Black", 0, 0, 0);

List<int> generatedRandomColorCode = GenerateRandomColorCode();
Console.WriteLine($"\nThe auto generated random RGB color code is: {generatedRandomColorCode[0]} {generatedRandomColorCode[1]} {generatedRandomColorCode[2]}");
CheckClosestColor(generatedRandomColorCode, "random code");
Console.WriteLine($"The random RGB code converted to HEX code: #{ShortenHexCode(ConvertToHex(generatedRandomColorCode))}");

Console.ReadKey();