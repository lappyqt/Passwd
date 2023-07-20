using Passwd.Interfaces;

namespace Passwd.Implementation;

//  Works similar to the Builder pattern, but returns an array rather than a new class object
 
public class PasswordCharactersCreator : IPasswordCharactersCreator
{
    private char[] characters = new char[] { };

    public static readonly char[] LowerCase = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
    public static readonly char[] UpperCase = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();
    public static readonly char[] Numbers = Enumerable.Range(0, 10).Select(x => char.Parse(x.ToString())).ToArray();
    public static readonly char[] SpecialSymbols = Enumerable.Range('!', 9).Select(x => (char)x).ToArray();

    public PasswordCharactersCreator AddLower(bool option)
    {
        characters = (option) ? Enumerable.Concat(characters, LowerCase).ToArray() : characters;
        return this;
    }

    public PasswordCharactersCreator AddUpper(bool option)
    {
        characters = (option) ? Enumerable.Concat(characters, UpperCase).ToArray() : characters;
        return this;
    }

    public PasswordCharactersCreator AddNumbers(bool option)
    {
        characters = (option) ? Enumerable.Concat(characters, Numbers).ToArray() : characters;
        return this;
    }

    public PasswordCharactersCreator AddSpecialSymbols(bool option)
    {
        characters = (option) ? Enumerable.Concat(characters, SpecialSymbols).ToArray() : characters;
        return this;
    }

    public char[] Create() => characters;
}