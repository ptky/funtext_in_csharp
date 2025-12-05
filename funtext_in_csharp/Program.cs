namespace funtext
{
    class Szoveg
    {
        static char[] karakterek =
        {
            'a','á','b','c','d','e','é','f','g','h','i','í','j','k','l','m','n','o','ó','ö','ő',
            'p','q','r','s','t','u','ú','ü','ű','v','w','x','y','z',
            ' ', '!', ',', ';', '.'
        };

        static void Main()
        {
            string text = bekeres();
            kiiras(text);
            Console.WriteLine("Nyomj meg egy gombot a kilepeshez...");
            Console.ReadKey();
        }

        public static string bekeres()
        {
            Console.Write("Add meg a szoveget: ");
            string text = Console.ReadLine();
            return text;
        }

        public static void vonalak(string text)
        {
            int hossz = text.Length;
            string design = "----";
            for (int i = 0; i < hossz; i++)
            {
                design += "-";
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(design);
            Console.ResetColor();
        }

        public static void kiiras(string text)
        {
            string betuk = "";
            int hossz = text.Length;

            for (int i = 0; i < hossz; i++) // az alap szovegen megyunk vegig

            {

                for (int j = 0; j < karakterek.Length; j++) // a karakterek tombon megyunk vegig es ha talalunk egyezest akkor kiirjuk

                {
                    string aktualis_abc = karakterek[j].ToString();
                    string aktualis_betu = text[i].ToString();

                    if (karakterek[j] == text[i])

                    {
                        string betu = karakterek[j].ToString();
                        betuk += betu;
                        vonalak(text);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"  {betuk}");
                        Console.ResetColor();
                        break;
                    }
                    else if (aktualis_abc.ToUpper() == aktualis_betu)
                    {
                        betuk += aktualis_betu;
                        vonalak(text);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"  {betuk}");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        vonalak(text);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"  {betuk + karakterek[j]}");
                        Console.ResetColor();
                        Thread.Sleep(30);
                        continue;

                    }
                }
            }
            vonalak(text);
        }
    }
}
