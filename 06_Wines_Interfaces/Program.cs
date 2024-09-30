using System.Xml.Linq;
using Seido.Utilities.SeedGenerator;
using Models;

namespace _05_Wines_Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Wines with Interface!");
        var rnd = new csSeedGenerator();

        IWineCellar wineCellar = null;
        //IWineCellar wineCellar = new csWineCellar("Martin's wine cellar", rnd, 20);

        Console.WriteLine($"\nWinecellar: {wineCellar.Name}");
        Console.WriteLine(wineCellar);

        Console.WriteLine($"Value of winecellar: {wineCellar.Value:N2} Sek");

        var hilo = wineCellar.WineHiLo();
        Console.WriteLine($"\nMost expensive wine:\n{hilo.mostExpensive}");
        Console.WriteLine($"Least expensive wine:\n{hilo.cheepest}");
    }
}

/* Exercises
1. Implement csWine to implement IWine and csWineCellar to implement IWinecellar 
2. Make sure you can build without error.
3. Make ONE change on row 13/14 to instantiate wineCellar. Note that all other code remains unchanged
*/

