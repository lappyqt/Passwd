namespace Passwd.Models;

public class PasswordOptions
{
    public int Length { get; set; } = 16;
    public bool Lowercase { get; set; } = true;
    public bool Uppercase { get; set; } = true;
    public bool Numbers { get; set; } = true;
    public bool SpecialSymbols { get; set; } = true;
    public string Exclude { get; set; } = string.Empty;
}