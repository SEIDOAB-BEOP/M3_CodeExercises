using Helpers;

namespace _02_Friends;

public enum enFriendLevel
{
    Friend, ClassMate, Family, BestFriend
}
public class csFriend
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Email { get; set; }
    public enFriendLevel Level { get; set; }
    public DateTime? BirthDay { get; set; } = null
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Friends!");
    }
}

//Exercises:
//1. Create a constructor to class csFriend that takes Name, Email, and Level as
//   Parameters and sets the corresponding properties.
//   Create an instance of csFriend(..) settign the properties with Arguments
//2. Create an empty constructor that sets all properties to random values
//   Create an instance of csFriend() setting the properties to random values.
//3. Modify the setter in Name so an Error is thrown if "" null is begin
//   set as Name
//4. Create a method ToString() in csFriends that presents the instance of csFriend.

