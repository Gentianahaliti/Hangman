Console.WriteLine("Hängagubbe");    //Skriver ut text på skärmen. Texten står inom citattecken eftersom det är en sträng,semikolonet avslutar kodraden.

{
    String ord = "katt";  // Sparar ordet som spelaren ska gissa.ord behövs för att programmet ska veta vilket ord det ska kontrollera
    int antalFel = 0;     // Räknaren börjar på 0 fel. antalFel behövs för att räkna fel och stoppa loopen efter 5 fel.
    while (antalFel < 5)      //While betyder "så länge". While (true) gör att koden mellan klammrarna upprepas hela tiden. Därför kan spelaren gissa flera bokstäver. . Loopen har ännu inget stoppvillkor, därför måste programmet stoppas manuellt med Ctrl+C under testningen. Senare lägger jag till ett riktigt stoppvillkor.kör så länge spelaren har mindre än 5 fel,när man får 5 fel, stoppa loopen.
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

            string[] hängaGubbe =    // Skapar en array som kan innehålla flera texter eller bilder.
            {
        "bild 0",           // Bilden när spelaren har 0 fel.
        "bild 1",           // Bilden när spelaren har 1 fel.
        "bild 2",           // Bilden när spelaren har 2 fel.
        "bild 3",           // Bilden när spelaren har 3 fel.
        "bild 4",           // Bilden när spelaren har 4 fel.
        "bild 5"            // Bilden när spelaren har 5 fel.
    };   // Avslutar arrayen.
            Console.WriteLine(hängaGubbe[antalFel]); //hängaGubbe är en lista/array med bilder, antalFel är siffran som visar hur många fel du har, höngaGubbe[antalFel] betyder "ta bilden som hör ihop med det antalet fel" ConsoleWriteLine(...) skriver ut den bilden i konsolen.(array och list är båda sätt att spara flera saker i samma variabel).
            if (antalFel == 5)  //Om antalFel blir 5 skriv texten "Du förlorade!"
            {
                Console.WriteLine("Du förlorade!");  //Det betyder skriv texten "Du förlorade!"
                break;   //Hoppa ut ur while-loopen direkt = Sluta loopen.
            } //Stänger if. = OM
        }  //stänger else. = Annars
    }  //stänger while. = Så länge
    ConsoleEriteLine("HängaGubbe");
String ord = "katt";
int antalFel = 0;

while (antalFel < 5)    // Loopen fortsätter så länge antalFel är mindre än 5.
}
Console.Write("Gissa en bokstav: ");
char gissning = Console.ReadLine()![0];   // char sparar en bokstav. ReadLine läser det spelaren skriver och [0] tar första bokstaven.

String ord = "katt";  //Sparar ordet som spelaren ska gissa //String används för text. Variabeln heter ord och innehåller texten "katt"= betyder att värdet "katt" sparas i variabeln ord.
if (ord.Contains(gissning))
{
    Console.WriteLine($"Bokstaven {gissning} finns i ordet!");
}
else
{
    Console.WriteLine("Fel gissat!");

    int antalFel = 0;  //Jag skapar en räknare som heter antalFel. Räknaren börjar på 0 eftersom spelaren inte har gissat fel ännu.
    antalFel++;
    Console.WriteLine($"Antal fel: [antalFel]");// Skriver ut bilden som hör ihop med antalet fel. // Hakparenteser [] används för att välja en plats i arrayen.
    Console.WriteLine(hängaGubbe{
        antalFel]);  //Välj bild beroende på fel.

        if (antalFel == 5)
        {
            Console.WriteLine("Du förlorade!");
            break;   //stoppa loopen.
        }
    }
}
