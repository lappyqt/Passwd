using Passwd.Models;

namespace Passwd.Interfaces;

internal interface IPasswordGenerator
{
    string GeneratePassword(PasswordOptions options);
}