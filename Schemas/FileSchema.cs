using System.Diagnostics.CodeAnalysis;

namespace AndOS.Core.Schemas;

public static class FileSchema
{
    [StringSyntax(StringSyntaxAttribute.Regex)] public const string RegexName = "^[^\\\\/:*?\"<>|]{1,100}$";
    public const byte MinLenghtName = 1;
    public const byte MaxLenghtName = 100;

    [StringSyntax(StringSyntaxAttribute.Regex)] public const string RegexExtension = @"^[a-zA-Z0-9]*$";
    public const byte MinLenghtExtension = 1;
    public const byte MaxLenghtExtension = 3;
}