﻿using Seido.Utilities.SeedGenerator;

namespace _07_IEquatable_IComparable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("07_IEquatable_IComparable");
        var rnd = new csSeedGenerator();
    }
}

//Exercise:
// 1. Implementera IEquatable på csPearl
// 2. Skapa två instanser av csPearl och testa om de är lika. Tips, tänk på att
//    har en copy constructor i csPearl som enkelt skapar en kopia av instansen
// 3. Implementera operator == och != overload i csPearl och använd dessa i
//    jämförelsen
// 4. Implementera IComparable på csPearl, skapa ett halsband med 100 pärlor.
//    och sortera halsbandet först efter pärlornas storlek och sedan form 
// 5. Implementera IEqutable på csNecklace
// 6. Skapa en copy constructor i csNecklace
// 7. Skapa två instanser av csNecklace och testa om de är lika. 

// 8. Ni som är snabba gör 1 -7  med csWine och cswineCellar.
//    sortera vinerna efter distrikt och sedan pris.


