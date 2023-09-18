namespace BlazorApp1.Helpers;

public static class ConverterExtensions
{
    public static string ConvertPathSeparator(this string input) => input.Replace("\\", "/");
    public static string ConvertColonToGrid(this string input) => input.Replace(":", "#");
}