namespace Karacsony
{
    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("U: Új fogás felvitele");
            Console.WriteLine("K: Összkalória");
            Console.WriteLine("L: Legnagyobb kalóriatartalmú fogás");
            Console.WriteLine("Esc: Kilépés");
        }

        static string FogasNevBeolvas()
        {
            Console.WriteLine("Kérlek add meg az új fogás nevét:");
            string fogasNeve = Console.ReadLine();
            return fogasNeve;
        }

        static ushort FogasKaloriaBeolvas()
        {
            ushort fogasKal;
            do
            {
                Console.WriteLine("Kérlek add meg az új fogás kalóriatartalmát:");
            } while (!ushort.TryParse(Console.ReadLine(), out fogasKal));
            return fogasKal;
        }

        class Fogas
        {
            public string nev;
            public ushort kaloria;
        }

        static uint osszKaloria(List<Fogas> fogasok)
        {
            uint osszKaloriaErteke = 0;
            foreach (Fogas fogas in fogasok)
            {
                osszKaloriaErteke += fogas.kaloria;
            }
            return osszKaloriaErteke;
        }

        static int maxKaloriatartalmu(List<Fogas> fogasok)
        {
//            int kaloriaTartalom = 0;
            int kaloriaIndex = 0;
            for (int i = 1; i < fogasok.Count; i++)
            {
                if (fogasok[i].kaloria > fogasok[kaloriaIndex].kaloria)
                {
//                    kaloriaTartalom = fogasok[i].kaloria;
                    kaloriaIndex = i;
                }
            }
            return kaloriaIndex;
        }


        static void Main(string[] args)
        {
            // lokális változók
            /*            List<string> fogasNevek = new List<string>();
                        List<ushort> fogasKaloriak = new List<ushort>();*/
            List<Fogas> fogasok = new List<Fogas>();

            Console.WriteLine("2-es típusú cukorbeteg vagy? (I/N)");
            ConsoleKey key = Console.ReadKey(true).Key;
            bool cukiE = (key == ConsoleKey.I);

            do
            {
                Menu();
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.U:
                        /*                        fogasNevek.Add(FogasNevBeolvas());
                                                fogasKaloriak.Add(FogasKaloriaBeolvas());*/

                        Fogas ujFogas = new Fogas();
                        ujFogas.nev = FogasNevBeolvas();
                        ujFogas.kaloria = FogasKaloriaBeolvas();
                        fogasok.Add(ujFogas);

                        // Ezek után kiírja az eddigi fogások összkalória tartalmát.
                        Console.WriteLine($"A fogások összkalória értéke: {osszKaloria(fogasok)}");

                        // Szorgalmi: Ha a felhasználó 2 - es típusú cukorbeteg és az összkalória az új fogással 3000 fölé emelkedne, akkor a program figyelmeztető üzenetet ír ki és az új fogást nem tárolja le.
                        break;
                    case ConsoleKey.K:
                        Console.WriteLine($"A fogások összkalória értéke: {osszKaloria(fogasok)}");
                        break;
                    case ConsoleKey.L:
                        if (fogasok.Count == 0)
                        {
                            Console.WriteLine("Nincs még fogás a menüben!");
                            break;
                        }
                        int index = maxKaloriatartalmu(fogasok);
                        Console.WriteLine($"Szeretnéd törölni a {fogasok[index].nev}? (I/N)");
                        if (Console.ReadKey(true).Key == ConsoleKey.I)
                            fogasok.RemoveAt(index);
                        break;
                    case ConsoleKey.Escape:
                        break;
                    default:
                        Console.WriteLine("Nem megfelelő billentyűt nyomtál!");
                        break;
                }
            } while (key != ConsoleKey.Escape);
        }
    }
}