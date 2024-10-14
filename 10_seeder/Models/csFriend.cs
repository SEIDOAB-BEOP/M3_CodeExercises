using Seido.Utilities.SeedGenerator;

namespace Models;

public enum enFriendLevel { Friend, ClassMate, Family, BestFriend }
public class csFriend
{
    private string _name;
    public string Name
    {
        get => _name;
        set{
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(Name));
            
            _name = value;
        }
    }

    public string Email { get; set; }
    public enFriendLevel Level { get; set; }

    public override string ToString() => $"{Name} is my {Level} and can be reached at {Email}";

    public csFriend(string Name, string Email, enFriendLevel Level)
    {
        this.Name = Name;
        this.Email = Email;
        this.Level = Level;
    }
    public csFriend(csSeedGenerator _seed)
    {
        string _firstName = _seed.FirstName;
        string _lastName = _seed.LastName;
        this.Name = $"{_firstName} {_lastName}";
        this.Email = _seed.Email(_firstName, _lastName);
        this.Level = _seed.FromEnum<enFriendLevel>();
    }
}