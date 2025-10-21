// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoParsing;

public class ParserTwoValues
{
    public static string ToString(string delimiter, string a, string b)
    {
        return a + delimiter + b;
    }

    public static List<double> ParseDouble(string delimiter, string s)
    {
        var parsed = ParseString(delimiter, s);
        var result = new List<double>(parsed.Count);
        foreach (var item in parsed) result.Add(double.Parse(item));
        return result;

        //return CAToNumber.ToNumber<double, string>(double.Parse, );
    }

    public static List<string> ParseString(string delimiter, string s)
    {
        return s.Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToList();
    }
}