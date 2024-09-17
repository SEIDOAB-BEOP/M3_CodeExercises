using Seido.Utilities.SeedGenerator;

namespace _05_chefs;

public class csChef
{
    public string Name { get; set; } = "Boring";
    public int Age { get; set; } = 0;

    public string Greeting => $"Hello";
    public string FavoriteDish { get; set; } = "nothing";

    public override string ToString() => $"{Greeting}, I am {Name}. I like {FavoriteDish}";

}

public class csFrenchChef : csChef
{
}
public class csGermanChef : csChef
{
}
public class csItalianChef : csChef
{
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Chefs!");
    }
}

//Exercise:
//1. Create a French, Italian, German chef that has it's own name, age, and favorite dish. Have them present themself
//2. Create a List<csChef> and add the three chefs to the list. 
//   Create a method that Loop through the list and present each chef.
//3. Give each chef it's own Greeting. Experiement with new, and virtual/override and present list of chef. 
//   what happend, explain.

