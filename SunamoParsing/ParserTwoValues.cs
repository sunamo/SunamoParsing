namespace SunamoParsing;

/// <summary>
/// Represents the parser two values type.
/// </summary>
public class ParserTwoValues
{
    /// <summary>
    /// To string.
    /// </summary>
    /// <param name="delimiter">The delimiter.</param>
    /// <param name="firstValue">The first value.</param>
    /// <param name="secondValue">The second value.</param>
    /// <returns>The to string result.</returns>
    public static string ToString(string delimiter, string firstValue, string secondValue)
    {
        return firstValue + delimiter + secondValue;
    }

    /// <summary>
    /// Parse double.
    /// </summary>
    /// <param name="delimiter">The delimiter.</param>
    /// <param name="text">The text.</param>
    /// <returns>The parse double result.</returns>
    public static List<double> ParseDouble(string delimiter, string text)
    {
        var parsed = ParseString(delimiter, text);
        var result = new List<double>(parsed.Count);
        foreach (var item in parsed) result.Add(double.Parse(item));
        return result;
    }

    /// <summary>
    /// Parse string.
    /// </summary>
    /// <param name="delimiter">The delimiter.</param>
    /// <param name="text">The text.</param>
    /// <returns>The parse string result.</returns>
    public static List<string> ParseString(string delimiter, string text)
    {
        return text.Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToList();
    }
}
