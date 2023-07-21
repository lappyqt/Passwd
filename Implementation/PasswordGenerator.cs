using Passwd.Interfaces;
using Passwd.Models;
using System.Text;

namespace Passwd.Implementation;

internal class PasswordGenerator : IPasswordGenerator
{
    public string GeneratePassword(PasswordOptions options)
    {
        if ((options.Lowercase || options.Uppercase || options.Numbers || options.SpecialSymbols) == false) { 
            throw new Exception("No characters available for password generation");
        }

        char[] characters = new CharactersCreator()
            .AddLower(options.Lowercase)
            .AddUpper(options.Uppercase)
            .AddNumbers(options.Numbers)
            .AddSpecialSymbols(options.SpecialSymbols)
            .Exclude(options.Exclude)
            .Create();

        var result = new StringBuilder();
        var random = new Random();

        for (int i = 0; i < options.Length; i++)
        {
            result.Append(characters[random.Next(0, characters.Length)]);
        }

        return result.ToString();
    }
}