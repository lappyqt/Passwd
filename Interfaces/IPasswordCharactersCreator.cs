using Passwd.Implementation;

namespace Passwd.Interfaces;

internal interface IPasswordCharactersCreator
{
    PasswordCharactersCreator AddLower(bool option);
    PasswordCharactersCreator AddUpper(bool option);
    PasswordCharactersCreator AddNumbers(bool option);
    PasswordCharactersCreator AddSpecialSymbols(bool option);
    char[] Create();
}