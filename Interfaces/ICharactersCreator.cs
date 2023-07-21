using Passwd.Implementation;

namespace Passwd.Interfaces;

internal interface ICharactersCreator
{
    CharactersCreator AddLower(bool option);
    CharactersCreator AddUpper(bool option);
    CharactersCreator AddNumbers(bool option);
    CharactersCreator AddSpecialSymbols(bool option);
    CharactersCreator Exclude(string symbols);
    char[] Create();
}