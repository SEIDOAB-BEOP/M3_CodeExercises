using Seido.Utilities.SeedGenerator;
using Models;

public class csNecklace
{
    public List<csPearl> Pearls {get; set;} = new List<csPearl>();

    public override string ToString(){
        
        string sRet = "";
        foreach (var item in Pearls)
        {
            sRet += $"{item}\n";
        }
        return sRet;
    }

    public csNecklace(csSeedGenerator _seeder, int nrItems)
    {
        for (int i = 0; i < nrItems; i++)
        {
            Pearls.Add(new csPearl(_seeder));
        }
    }
}