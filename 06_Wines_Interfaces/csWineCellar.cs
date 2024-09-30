using System;
using Seido.Utilities.SeedGenerator;

namespace Models
{
    public class csWineCellar //: IWineCellar
    {
        public override string ToString()
        {
            var sRet = "";
            // foreach (var wine in Wines)
            // {
            //     sRet += $"{wine}\n";
            // }
            return sRet;
        }

        public csWineCellar() { }
        public csWineCellar(string cellarname, csSeedGenerator _seeder, int nrItems)
        {}
        public csWineCellar(string cellarname, List<IWine> wines)
        {}
    }
}

