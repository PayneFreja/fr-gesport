using System;

int points = 0;
Console.WriteLine("Frågesport om Freja, du svarar med a,b eller c på varje fråga.");
Console.WriteLine("Lycka till!");

// -----------------------------------------------------------------------------

Console.WriteLine("Hur lång är Freja");
Console.WriteLine("a)166 b)168 c)164");
string svar1 = Console.ReadLine();
if (svar1 == "a")
{
    points++;
    Console.WriteLine("Bra jobbat!");
}
else
{
    Console.WriteLine("Buuuuuu");
}

// -----------------------------------------------------------------------------

Console.WriteLine("Vilken är Frejas favoritfärg?");
Console.WriteLine("a)Blå b)Svart c)Lila");
string svar2 = Console.ReadLine();
if (svar2 == "c")
{
    points++;
    Console.WriteLine("Najs du hade rätt.");
}
else
{
    Console.WriteLine("Känner du ens mig? Fel!");
}

// -----------------------------------------------------------------------------

Console.WriteLine("Vilket husdjur har Freja?");
Console.WriteLine("a)Hund b)Marsvin c)Fågel d)Hamster e)Freja har inga husdjur!");
string svar3 = Console.ReadLine();
if (svar3 == "d")
{
    points++;
    Console.WriteLine("Du hade rätt!");
    Console.WriteLine("Fun fact: Hon heter Puff, och hennes syster heter Piff");
}
else
{
    Console.WriteLine("Fel! Jag har världens sötaste hamster.");
}

// -----------------------------------------------------------------------------

Console.WriteLine("Vilken sport har Freja spelat i laget Sikla IF");
Console.WriteLine("a)Basket b)Innebandy c)Hockey d)Fotboll e)Handboll");
string svar4 = Console.ReadLine();
if (svar4 == "d")
{
    points++;
    Console.WriteLine("Bra där");
}
else
{
    Console.WriteLine("Sämst det va fotboll");
}

// -----------------------------------------------------------------------------

Console.WriteLine("Hur många ringar har Freja totalt på händerna");
Console.WriteLine("a)1-3 b) c)4-6 d)7-9 e)10 eller mer");
string svar5 = Console.ReadLine();
if (svar5 == "d")
{
    points++;
    Console.WriteLine("Najs!");
}
else
{
    Console.WriteLine("Bruh.");
}
// -----------------------------------------------------------------------------

Console.WriteLine($"Nu är frågesporten över, du fick {points} poäng");
Console.ReadLine();
