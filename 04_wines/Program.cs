using Seido.Utilities.SeedGenerator;

namespace _04_wines;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
//Exercise:
// 1. Modellera en flaska vin en C# class. Utmärkande för ett vin är
//    Druva: Reissling, Tempranillo, Chardonay, Shiraz, Cabernet Savignoin, Syrah
//    Typ: Rött, vitt, rose
//    Namn: namnet på vinet
//    Land: Tyskland, Frankrike, Spanien
//    Pris:
//
// 2. När vinet väl är skapad så ska man bara kunna ändra pris.
//
// 3. Override ToString i din vinklass och  presentera vinet.
//
// 4. Modellera en vinkällare. Vinkällaren ska ha ett namn och address.
//    Lägg in 20 flaskor av slumpmässig initierat vin
//
// 5. Skapa metoder i vinkällaren som visar det billigaste och dyraste vinet i vinkällaren?
//
// 6. Skapa en metod som ger värdet av vinkällaren?
//
// 7. Deklarera en contruktor som tillåter dig att själv bestämma alla csWine public properties
//
// 10.Deklarera en Copy constructor i modellerna av vin och vinkällaren.
//
// 11.Använd copy constructorn för att skapa en kopia av en vinkällare
