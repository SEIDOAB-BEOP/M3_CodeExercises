using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using Seido.Utilities.SeedGenerator;

namespace _07_IEquatable_IComparable
{
    public enum enPearlColor { Black, White, Pink }
    public enum enPearlShape { Round, DropShaped }
    public enum enPearlType { FreshWater, SaltWater }

    #region Pearl as a class
    public class csPearl //: IEquatable<csPearl>, IComparable<csPearl>
    {
        public int Size { get; set; }
        public enPearlColor Color { get; init; }
        public enPearlShape Shape { get; init; }
        public enPearlType Type { get; init; }

        public override string ToString() => $"{Size}mm {Color} {Shape} {Type} pearl.";


        public csPearl() { }
        public csPearl(csSeedGenerator _seeder)
        {
            Size = _seeder.Next(5, 25);
            Color = _seeder.FromEnum<enPearlColor>();
            Shape = _seeder.FromEnum<enPearlShape>();
            Type = _seeder.FromEnum<enPearlType>();
        }
        public csPearl(int _size, enPearlColor _color, enPearlShape _shape, enPearlType _type)
        {
            Size = _size;
            Color = _color;
            Shape = _shape;
            Type = _type;
        }
    }
    #endregion
}

