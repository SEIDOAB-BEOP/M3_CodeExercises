﻿using System;
using System.Security.Cryptography;
using System.Text;

using Seido.Utilities.SeedGenerator;

namespace _03_Pearls;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

//Exercise:
// 1. Modellera en pärlan i en C# class. Utmärkande för en pärla är
//    Storlek: Diameter 5mm till 25mm
//    Färg: Svart, Vit, Rosa
//    Form: Rund, Droppformad
//    Typ: Sötvatten, Saltvatten
//
// 2. När pärlan väl är skapad så ska man inte kunna ändra den.
//
// 3. Skapa en ToString i din pärlklass som presenterar pärlan.
//
// 4. Skapa ett halsband bestående av 10 pärlor av slumpmässig storlek, färg
//    form, och typ
//
// 5. Vilken färg, form och typ har den minsta och den största pärlan i halsbandet?
//
// 6. Deklarera en contruktor som tillåter dig att själv bestämma alla csPearl public properties
//
// 7. Deklarera en Copy constructor.
//
// 8. Använd copy constructorn för att skapa ett nytt halsband som är en kopia av ursprunget



