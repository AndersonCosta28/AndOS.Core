using System.Diagnostics.CodeAnalysis;

namespace AndOS.Core.Schemas;

public static class AccountSchema
{
    [StringSyntax(StringSyntaxAttribute.Regex)] public const string RegexName = @"^[a-zA-Z0-9]*$";
    public const byte MinLenghtName = 4;
    public const byte MaxLenghtName = 15;
}