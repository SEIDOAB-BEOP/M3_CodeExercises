using Seido.Utilities.SeedGenerator;
namespace Models;

public enum enCarColor { Brown, Red, Green, Burgundy}
public enum enCarBrand { Boxcar, Ford, Jaguar, Honda}
public enum enCarModel { Boxmodel, Mustang_GT, XF, Civic}

public class csCar
{
    public enCarColor Color {get; init;}
    public enCarBrand Brand {get; set;}
    public enCarModel Model {get; set;}
    
    public override string ToString() => $"I am a {Color} {Brand} {Model}";

    public csCar() {}
    public csCar(csSeedGenerator _seeder)
    {
        Color = _seeder.FromEnum<enCarColor>();
        Brand = _seeder.FromEnum<enCarBrand>();
        Model = _seeder.FromEnum<enCarModel>();           
    }
}