Console.WriteLine("Välkommen till hängagubbe");
Console.Write("Skriv ett ord: ");
string ord = Console.ReadLine()?.Trim().ToLower() ?? "katten";
var guessedright = new List<char>();
var guessedwrong = new List<char>();
int antalfel = 0;

while (antalfel < 7 && !ord.All(guessedright.Contains))
{
    VisaHangman(antalfel);
    Console.WriteLine($"Ord: {VisaOrd(ord, guessedright)}");
    Console.WriteLine($"Fel gissningar: {string.Join(", ", guessedwrong)}");
    Console.Write("Gissa en bokstav: ");
    string input = Console.ReadLine()?.Trim().ToLower() ?? "";

    if (input.Length != 1 || !char.IsLetter(input[0]))
    {
        Console.WriteLine("Skriv exakt en bokstav.");
        continue;
    }

    char guess = input[0];
    if (guessedright.Contains(guess) || guessedwrong.Contains(guess))
    {
        Console.WriteLine("Du har redan gissat den bokstaven.");
        continue;
    }

    if (ord.Contains(guess))
        guessedright.Add(guess);
    else
    {
        guessedwrong.Add(guess);
        antalfel++;
    }
}

VisaHangman(antalfel);
Console.WriteLine(ord.All(guessedright.Contains) ? $"Du vann! Ordet var {ord}." : $"Du förlorade. Ordet var {ord}.");

static string VisaOrd(string ord, List<char> gissade)
{
    return string.Join(" ", ord.Select(tecken => gissade.Contains(tecken) ? tecken : '_'));
}

static void VisaHangman(int fel)
{
    string[] bilder =
    {
        "  +---+\n      |\n      |\n      |\n     ===",
        "  +---+\n  O   |\n      |\n      |\n     ===",
        "  +---+\n  O   |\n  |   |\n      |\n     ===",
        "  +---+\n  O   |\n /|   |\n      |\n     ===",
        "  +---+\n  O   |\n /|\\  |\n      |\n     ===",
        "  +---+\n  O   |\n /|\\  |\n /    |\n     ===",
        "  +---+\n  O   |\n /|\\  |\n / \\  |\n     ===",
        "  +---+\n  X   |\n /|\\  |\n / \\  |\n     ==="
    };

    Console.WriteLine(bilder[Math.Clamp(fel, 0, bilder.Length - 1)]);
}

