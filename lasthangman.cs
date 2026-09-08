Console.WriteLine("Hängagubbe");    //Skriver ut text på skärmen. Texten står inom citattecken eftersom det är en sträng,semikolonet avslutar kodraden.

{
    String ord = "katt";  // Sparar ordet som spelaren ska gissa.ord behövs för att programmet ska veta vilket ord det ska kontrollera
    int antalFel = 0;     // Räknaren börjar på 0 fel. antalFel behövs för att räkna fel och stoppa loopen efter 5 fel.

    string[] hängaGubbe =    // Skapar en array som kan innehålla flera texter eller bilder.
    {
        @"  +---+
      |
      |
      |
     ===",                  // Bilden när spelaren har 0 fel.
        @"  +---+
      |
      O
      |
      |
     ===",           // Bilden när spelaren har 1 fel.
       @"  +---+
      |
      O
     /|
      |
     ===",                // Bilden när spelaren har 2 fel.
       @"  +---+
      |
      O
     /|\
      |
     ===",           // Bilden när spelaren har 3 fel.
        @"  +---+
      |
      O
     /|\
     / |
     ===",         // Bilden när spelaren har 4 fel.
       @"  +---+
      |
      O
     /|\
     / \
     ===",          // Bilden när spelaren har 5 fel.
    };   // Avslutar arrayen.

    while (antalFel < 5)      // While betyder "så länge". Loopen upprepas så länge antalFel är mindre än 5. När spelaren får 5 fel stannar loopen.
    {    //{ visar var loopen börjar. All kod fram till den avslutande } hör då till loopen och upprepas.

        Console.Write("Gissa en bokstav: ");   //Skriver text på skärmen utan att automatiskt hoppa till nästa rad. Dörför kan spelaren skriva sitt svar direkt efter frågan.

        Char gissning = Console.ReadLine()![0];  //Char sparar en enda bokstav. Console.ReadLine() läser det jag skriver och [0] väljer den första bokstaven, gissning är namnet på variabeln.

        if (ord.Contains(gissning))    //if betyder "om" ord.Contains(gissning) kontrollerar om ordet innehåller bokstaven jag gissade.
        {
            Console.WriteLine($"Bokstaven {gissning} finns i ordet!");
        }         // $ gör att jag kan anväda en variabel inne i texten. {gissning} ersätts med bokstaven som spelaren skrev. Om spelaren skriver a blir texten: Bokstaven a finns i ordet!

        else
        {
            Console.WriteLine("Fel gissat!");  // else betyder "annars". Om villkoret i if inte är sant körs koden i else. Därför skrivs "fel gissat" ut när bokstaven inte finns i ordet.

            antalFel++;  //När gissningen är fel går programmet in i else. Då skriver det först ut "Fel gissat!" och sedan ökar antalFel med 1.

            Console.WriteLine($"Antal fel: {antalFel}");  //Skriv ut hur många fel spelaren har gjort. Antal fel: " = vanlig text och {antalFel} = visa siffran som finns i räknaren. Om spelaren gjort två fel visas Antal fel: 2.

            Console.WriteLine(hängaGubbe[antalFel]); // hängaGubbe är en array med bilder. antalFel visar hur många fel du har. hängaGubbe[antalFel] betyder "ta bilden som hör ihop med det antalet fel". Console.WriteLine(...) skriver ut bilden i konsolen.
            if (antalFel == 5)  //Om antalFel blir 5 skriv texten "Du förlorade!"
            {
                Console.WriteLine("Du förlorade!");  //Det betyder skriv texten "Du förlorade!"
                break;   //Hoppa ut ur while-loopen direkt = Sluta loopen.
            } //Stänger if. = OM
        }  //stänger else. = Annars
    }  //stänger while. = Så länge
