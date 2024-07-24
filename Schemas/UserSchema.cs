using System.Diagnostics.CodeAnalysis;

namespace AndOS.Core.Schemas;

public static class UserSchema
{
    [StringSyntax(StringSyntaxAttribute.Regex)] public const string RegexUserName = @"^[a-zA-Z0-9]*$";
    public const byte MinLenghtUserName = 4;
    public const byte MaxLenghtUserName = 15;

    [StringSyntax(StringSyntaxAttribute.Regex)] public const string RegexPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d]).{6,}$";
    public const byte MinLenghtPassword = 6;
    public const byte MaxLenghtPassword = 100;
}