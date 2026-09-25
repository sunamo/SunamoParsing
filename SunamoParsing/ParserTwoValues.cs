namespace SunamoParsing;

public class ParserTwoValues
{
    public static string ToString(string delimiter, string firstValue, string secondValue)
    {
        return firstValue + delimiter + secondValue;
    }

    public static List<double> ParseDouble(string delimiter, string text)
    {
        var parsed = ParseString(delimiter, text);
        var result = new List<double>(parsed.Count);
        foreach (var item in parsed) result.Add(double.Parse(item));
        return result;
    }

    public static List<string> ParseString(string delimiter, string text)
    {
        return text.Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToList();
    }
}
