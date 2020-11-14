using System;

namespace Demo_struct_Kaart
{
    class Program
    {
        enum Kleur { Rood, Zwart}
        enum Teken { Schoppen, Ruiten, Klaveren, Harten}
        enum Rang { Aas, Twee ,Drie,Vier, Vijf,Zes,Zeven,Acht,Negen,Tien,Boer, Dame,Heer,Joker}
        struct Kaart
        {
            Kleur Kaart_Kleur;
            Teken Kaart_Teken;
            Rang Kaart_Rang;
            //constructor voor Kaart
            public Kaart(Kleur kleur, Teken teken, Rang rang)
            {
                Kaart_Kleur = kleur;
                Kaart_Rang = rang;
                Kaart_Teken = teken;
            }
            //methode om gegevens kaart af te printen 
            public void PrintKaart()
            {
                Console.WriteLine($"Kaart is: {Kaart_Kleur} {Kaart_Teken} {Kaart_Rang}");
            }
        }
        static void Main(string[] args)
        {
            Kaart kaart1 = new Kaart(Kleur.Rood, Teken.Harten, Rang.Dame);
            kaart1.PrintKaart();

            Kaart kaart2 = new Kaart(Kleur.Zwart, Teken.Schoppen, Rang.Boer);
            kaart2.PrintKaart();
        }
    }
}
