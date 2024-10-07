using System;
using Seido.Utilities.SeedGenerator;
using Models;


Console.WriteLine("Hello, Inheritance!");

Console.WriteLine("\nShapes");
csTriangle t1 = new csTriangle() { Height = 100, Width = 200 };
System.Console.WriteLine(t1);

csRectangle r1 = new csRectangle() { Height = 100, Width = 200 };
System.Console.WriteLine(r1);

csSquare sq1 = new csSquare() { Height = 25};
System.Console.WriteLine(sq1);

csSquare sq2 = new csSquare() { Width = 50};
System.Console.WriteLine(sq2);

Console.WriteLine("\n\nChefs");


/*Exercise:
With Models/csShapes.cs:
1. Implement operator overlad on == and !== in base class csShapes. 
2. Instantiate a two of each Rectangles, Triangles, Squares with same Height and Width and test the operator ==
3. Implement a Circle as a derivative of Square. Have the Circle present itself and its area. Area Radius*Radius*Math.Pi
   Hint: Circle can have a property Radius that gets and sets the parents Square's property Width

With Models/csChef.cs
1. Create a French, Italian, German chef that has it's own name, age, and favorite dish. Have them present themself
2. Create a List<csChef> and add the three chefs to the list. 
   Create a method that Loop through the list and present each chef.

Polymorfism
1. Give each chef it's own Greeting. Experiement with new, and virtual/override and present list of chef. 
   what happend, explain.
2. Make a list of Shapes, and add an instance of each shapehave to the list. Haveeach shape present itself with the right Area.


*/