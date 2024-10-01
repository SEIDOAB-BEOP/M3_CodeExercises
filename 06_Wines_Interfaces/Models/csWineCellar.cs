using System;
using System.Dynamic;
using Seido.Utilities.SeedGenerator;

namespace Models
{
    public class csWineCellar //: IWineCellar
    {
        // public override string ToString()
        // {
        //     var sRet = $"\nCellar {Name} has {Count} bottles:";
        //     foreach (var wine in Wines)
        //     {
        //         sRet += $" -{wine}";
        //     }
        //     return sRet;
        // }

        public csWineCellar() { }
        public csWineCellar(string cellarname, csSeedGenerator _seeder, int nrItems)
        {
        }
        public csWineCellar(string cellarname, List<IWine> wines)
        {
        }
    }
}

