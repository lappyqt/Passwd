# Passwd
Simple password generator for .NET

## Basic example

```cs
var options = new PasswordOptions
{  
    Length = 24,
    Exclude = "@()"
};

var passwordGenerator = new PasswordGenerator();
var password = passwordGenerator.GeneratePassword(options);
```

## Password generation options

| Option           | Type        |  Default value |
| ---------------- | ----------- | -------------- |
| Length           | Int         | 16             |
| Lowercase        | Bool        | true           |
| Uppercase        | Bool        | true           |
| Numbers          | Bool        | true           |
| SpecialSymbols   | Bool        | true           |
| Exclude          | String      | Empty          |
