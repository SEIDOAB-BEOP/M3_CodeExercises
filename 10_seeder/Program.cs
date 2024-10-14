using Models;
using Seido.Utilities.SeedGenerator;

Console.WriteLine("Hello Seeder!");
var _seeder = new csSeedGenerator();



/* Exercises
1. Explore csSeedGenerator interface ISeed<T>. 
   - What does it require of a class that implements it?
2. Implement ISeed on csCar, csFriend, csPearl, csWine, e.g. ISeed<csCar> ... etc
3. Explore csSeedGenerator public List<TItem> ItemsToList<TItem>(int NrOfItems)
   - What interface is required to be implemented by a class to use ItemsToList?
   - Use ItemsToList to generate a list of 100 instances of csCar, csFriend, csPearl and csWine

4. Explore csSeedGenerator public List<TItem> UniqueItemsToList<TItem>(int tryNrOfItems, List<TItem> appendToUnique = null)
   - What interfaces are required to be implemented by a class to use ItemsToList?
   - Use UniqueItemsToList to generate a list of unique 100 instances of csCar, csFriend, csPearl and csWine
 
*/
