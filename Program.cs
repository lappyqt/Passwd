using Passwd.Implementation;
using Passwd.Models;

var options = new PasswordOptions
{  
    Length = 24
};

var passwordGenerator = new PasswordGenerator();
var password = passwordGenerator.GeneratePassword(options);

Console.WriteLine(password);