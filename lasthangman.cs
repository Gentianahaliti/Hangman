Console.WriteLine("Hängagubbe");

string ord = "katt";
int antalFel = 0;

string[] hängaGubbe =
{
    "Steg 0",
    "Steg 1",
    "Steg 2",
    "Steg 3",
    "Steg 4",
    "Steg 5"
};

while (antalFel < 5)
{
    Console.Write("Gissa en bokstav: ");
    char gissning = Console.ReadLine()![0];

    if (ord.Contains(gissning))
    {
        Console.WriteLine($"Bokstaven {gissning} finns i ordet!");
    }
    else
    {
        Console.WriteLine("Fel gissat!");
        antalFel++;
        Console.WriteLine($"Antal fel: {antalFel}");
        Console.WriteLine(hängaGubbe[antalFel]);

        if (antalFel == 5)
        {
            Console.WriteLine("Du förlorade!");
            break;
        }
    }
}
