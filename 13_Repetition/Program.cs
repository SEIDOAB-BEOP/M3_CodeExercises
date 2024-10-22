// See https://aka.ms/new-console-template for more information
using Models;
using Seido.Utilities.SeedGenerator;

Console.WriteLine("13_repetition!");
var _seeder = new csSeedGenerator();

Console.WriteLine("Create a couple of members");
IMember member1 = null;
Console.WriteLine($"member1: {member1}");
IMember member2 = null;
Console.WriteLine($"member2: {member2}");

Console.WriteLine("Test the copy constructor");
IMember member3 = null;
Console.WriteLine($"member3: {member3}");

Console.WriteLine("\nCreate a 20 Hilton members");
IMemberList HiltonMembers = null;
Console.WriteLine(HiltonMembers.Sort());

Console.WriteLine("\nCreate a 20 Radisson members");
IMemberList RadissonMembers = null;
Console.WriteLine(HiltonMembers.Sort());

Console.WriteLine("Test the indexer");
Console.WriteLine($"\nHilton member[0]: {HiltonMembers[0]}");
Console.WriteLine($"Radisson member[0]: {RadissonMembers[0]}");
Console.WriteLine();

Console.WriteLine("Test the copy constructor");
IMemberList copyList = null;
Console.WriteLine(copyList);
Console.WriteLine(copyList[10]);

Console.WriteLine("Test fluid pattern");
copyList = copyList.RemoveFirst().RemoveLast().AddFirst(member1).AddLast(member2);
Console.WriteLine(copyList);


/* Exercises
1. Implement csMember och csMemberList
2. Modify the code in program.cs so you test the class functinality

3. Create two class factories in csMemberList.cs that creates a
   a Sheraton memberlist and a Scandic memberlist, each with a given number of members
*/