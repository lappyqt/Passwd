using Passwd.Implementation;
using Passwd.Models;

var options = new PasswordOptions
{  
    Length = 24,
    Lowercase = true,
    Uppercase = true,
    Numbers = true,
    SpecialSymbols = true
};

var passwordGenerator = new PasswordGenerator();
var password = passwordGenerator.GeneratePassword(options);

Console.WriteLine(password);