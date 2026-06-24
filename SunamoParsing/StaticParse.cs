namespace SunamoParsing;

public static class StaticParse
{
    public static string GetString(List<string> list, int index)
    {
        var result = list[index];
        return result.TrimEnd(' ');
    }

    public static int GetInt(List<string> list, int index)
    {
        return int.Parse(list[index]);
    }

    public static float GetFloat(List<string> list, int index)
    {
        return float.Parse(list[index]);
    }

    public static long GetLong(List<string> list, int index)
    {
        return long.Parse(list[index]);
    }

    public static bool GetBoolMS(List<string> list, int index)
    {
        return bool.Parse(list[index]);
    }

    public static bool GetBool(List<string> list, int index)
    {
        return Convert.ToBoolean(list[index]);
    }

    public static string GetBoolS(List<string> list, int index)
    {
        return GetBool(list, index) ? "Yes" : "No";
    }

    public static DateTime GetDateTime(List<string> list, int index)
    {
        var dateText = list[index];
        return DateTime.Parse(dateText, CultureInfo.GetCultureInfo("cs"));
    }

    public static string GetDateTimeS(List<string> list, int index)
    {
        return DateTime.Parse(list[index].Trim()).ToString();
    }

    public static byte[]? GetImage(List<string> list, int index)
    {
        object value = list[index];
        if (value == DBNull.Value)
        {
            return null;
        }

        ThrowEx.NotImplementedMethod();
        return null;
    }

    public static decimal GetDecimal(List<string> list, int index)
    {
        return decimal.Parse(list[index]);
    }

    public static double GetDouble(List<string> list, int index)
    {
        return double.Parse(list[index]);
    }

    public static short GetShort(List<string> list, int index)
    {
        return short.Parse(list[index]);
    }

    public static byte GetByte(List<string> list, int index)
    {
        return byte.Parse(list[index]);
    }

    public static Guid GetGuid(List<string> list, int index)
    {
        return Guid.Parse(list[index]);
    }
}
