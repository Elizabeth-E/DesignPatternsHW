using assignment1;
using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
        new Program().Start();
    }
    void Start()
    {
        List<Character> characters = new List<Character>();
        characters.Add(new Queen());
        characters.Add(new Troll());
        characters.Add(new King());
        characters.Add(new Knight());
        foreach (Character character in characters)
            character.Fight();
        Console.WriteLine();
        // change weapon of knight to axe
        characters[3].Weapon = new AxeBehaviour();
        foreach (Character character in characters)
            character.Fight();
    }
}