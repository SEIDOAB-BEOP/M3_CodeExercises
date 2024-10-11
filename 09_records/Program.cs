using System.Security.Cryptography;
using System.Text;

using Models;
using Seido.Utilities.SeedGenerator;

Console.WriteLine("Hello Pearls!");
var _seeder = new csSeedGenerator();


//Exercise:
// 1. Modellera en pärlan i en C# record. Utmärkande för en pärla är
//    Storlek: Diameter 5mm till 25mm
//    Färg: Svart, Vit, Rosa
//    Form: Rund, Droppformad
//    Typ: Sötvatten, Saltvatten
//
// 2. När pärlan väl är skapad så ska man inte kunna ändra den.
//
// 4. Skapa ett lista bestående av 10 pärlor av slumpmässig storlek, färg
//    form, och typ
//
// 5. Skriv ut listan
