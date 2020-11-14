using System;

namespace Demo_struct_Boek
{

    class Program
    {
        struct Boek
        {
            public double Prijs; //veld of field
            public string Auteur;//veld of field
            public string Titel;//veld of field
            //constructor maken: wordt aangeroepen wanneer je een new Boek()
            //dient voornamelijk om de velden te initialiseren
            public Boek(double prijs, string titel, string auteur)
            {
                Prijs = prijs;
                Auteur = auteur;
                Titel = titel;
            }
            //methode PrintBoek
            public void PrintBoek()
            {
                Console.WriteLine($"Boek '{Titel}' van {Auteur} Prijs: {Prijs}");
            }
        }
        static void Main(string[] args)
        {
            Boek boek1 = new Boek(15.5, "Harry Potter - De steen der wijzen", "J.K. Rowling");
            boek1.PrintBoek();
            //Boek boek1 = new Boek();
            //boek1.Prijs = 15.5;
            //boek1.Titel = "Harry Potter - De steen der wijzen";
            //boek1.Auteur = "J.K. Rowling";
            Boek boek2 = new Boek(35.15, "Pro C# 8", "A. Wesley");
            boek2.PrintBoek();
            //Boek boek2 = new Boek();
            //boek2.Prijs = 35.15;
            //boek2.Titel = "Pro C# 8";
            //boek2.Auteur = "A. Wesley";

            //Console.WriteLine($"Titel van boek1: {boek1.Titel}");
            //Console.WriteLine($"Titel van boek2: {boek2.Titel}");
            //Console.WriteLine($"Prijs van de 2 boeken: {boek1.Prijs + boek2.Prijs}");
        }
    }
}
