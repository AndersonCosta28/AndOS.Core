using System.Diagnostics.CodeAnalysis;

namespace AndOS.Core.Schemas;

public static class FolderSchema
{
    [StringSyntax(StringSyntaxAttribute.Regex)] public const string RegexName = "^[^\\\\/:*?\"<>|]*[^\\\\/:*?\"<>|.\\s]$";
    public const byte MinLenghtName = 1;
    public const byte MaxLenghtName = 100;
}