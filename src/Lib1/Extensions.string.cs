namespace Lib1;

public static partial class Extensions
{
    public static bool IsNullOrEmpty(this string? @this)
    {
        return string.IsNullOrEmpty(@this);
    }
}