using System.Runtime.CompilerServices;

Console.WriteLine("Inserisci il titolo del libro");
string titolo = Console.ReadLine();

Console.WriteLine("Inserisci l'autore/i");
string autore = Console.ReadLine();

Console.WriteLine("Inserisci il codice ISBN-10");
string isbn10 = Console.ReadLine();

Console.WriteLine("Inserisci il codice ISBN-13");
string isbn13 = Console.ReadLine();

Console.WriteLine("Inserisci il numero di pagine");
int nPagine = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il peso del libro");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la larghezza del libro");
double larghezza = double.Parse(Console.ReadLine());

Console.WriteLine("Inserisci l'altezza del libro");
double altezza = double.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la profondità del libro");
double profondità = double.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la valutazione media del libro");
double valMed = double.Parse(Console.ReadLine());

int valMax = 5;

Console.WriteLine("Inserisci il numero di recensioni del libro");
float numRecensioni = float.Parse(Console.ReadLine());

Console.WriteLine("Il libro è disponibile su dispositivo kindle? y = 'si' n = 'no'");
string kindle = Console.ReadLine();
while (kindle != "y" && kindle != "n")
{
        Console.WriteLine("Errore: inserire y o n");
        kindle = Console.ReadLine();
}

Console.WriteLine("Il libro è disponibile in copertina flessibile? y = 'si' n = 'no'");
string copFlex = Console.ReadLine();
while (copFlex != "y" && copFlex != "n")
{
    Console.WriteLine("Errore: inserire y o n");
    copFlex = Console.ReadLine();
}


Console.WriteLine("---------------IL LIBRO DI OGGI: " + titolo + " ----------------");
Console.WriteLine("autore/i: " + autore);
Console.WriteLine("ISBN-10: " + isbn10);
Console.WriteLine("ISBN-13: " + isbn13);
Console.WriteLine("Numero Pagine: " + nPagine);
Console.WriteLine("Peso: " + peso + " g");
Console.WriteLine("Dimensioni" + larghezza + "x" + altezza + "x" + profondità + " cm");
Console.WriteLine("Valutazione: " + valMed + " su " + valMax);
Console.WriteLine("Recensito da: " + numRecensioni + " lettori");

if (kindle == "y")
{
    Console.WriteLine("Il libro è disponibile su dispositivo kindle");
}
else
{
    Console.WriteLine("Il libro non è disponibile su dispositivo kindle");
}

if (copFlex == "y")
{
    Console.WriteLine("Il libro è disponibile in copertina flessibile");
}
else
{
    Console.WriteLine("Il libro non è disponibile in copertina flessibile");
}




