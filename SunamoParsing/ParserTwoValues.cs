namespace SunamoParsing;

/// <summary>
/// Provides methods for parsing and formatting two-value delimited strings.
/// </summary>
public class ParserTwoValues
{
    /// <summary>
    /// Joins two string values with a delimiter.
    /// </summary>
    /// <param name="delimiter">The delimiter to place between values.</param>
    /// <param name="firstValue">The first value.</param>
    /// <param name="secondValue">The second value.</param>
    /// <returns>The concatenated string with the delimiter.</returns>
    public static string ToString(string delimiter, string firstValue, string secondValue)
    {
        return firstValue + delimiter + secondValue;
    }

    /// <summary>
    /// Splits a delimited string and parses each part as a double.
    /// </summary>
    /// <param name="delimiter">The delimiter to split by.</param>
    /// <param name="text">The delimited string to parse.</param>
    /// <returns>A list of parsed double values.</returns>
    public static List<double> ParseDouble(string delimiter, string text)
    {
        var parsed = ParseString(delimiter, text);
        var result = new List<double>(parsed.Count);
        foreach (var item in parsed) result.Add(double.Parse(item));
        return result;
    }

    /// <summary>
    /// Splits a delimited string into a list of strings.
    /// </summary>
    /// <param name="delimiter">The delimiter to split by.</param>
    /// <param name="text">The delimited string to split.</param>
    /// <returns>A list of non-empty string parts.</returns>
    public static List<string> ParseString(string delimiter, string text)
    {
        return text.Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToList();
    }
}
