using System;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static void Run()
    {
        // Arrays  
        double[] prijzen = new double[] { 1.99, 2.49, 3.75, 4.50 };
        string[] artikelen = { "Brood", "Melk", "Kaas", "Eieren" };
        Formulier[] formulieren = new Formulier[3];

        // Formulieren vullen  
        formulieren[0] = new Formulier("Klant 1", "Goed product!");
        formulieren[1] = new Formulier("Klant 2", "Niet slecht, kan beter.");
        formulieren[2] = new Formulier("Klant 3", "Uitstekend!");

        // For-loop voor artikelen en prijzen  
        for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine($"Artikel: {artikelen[i]}, Prijs: {prijzen[i]:C}");
        }

        // Foreach-loop voor reviews  
        foreach (Formulier formulier in formulieren)
        {
            Console.WriteLine($"Naam: {formulier.Naam}, Review: {formulier.Review}");
        }
    }
}

// Definitie van de Formulier klasse  
class Formulier
{
    public string Naam { get; }
    public string Review { get; }

    public Formulier(string naam, string review)
    {
        Naam = naam;
        Review = review;
    }
}