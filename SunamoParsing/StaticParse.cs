namespace SunamoParsing;

/// <summary>
/// Represents the static parse type.
/// </summary>
public static class StaticParse
{
    /// <summary>
    /// Get string.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get string result.</returns>
    public static string GetString(List<string> list, int index)
    {
        var result = list[index];
        return result.TrimEnd(' ');
    }

    /// <summary>
    /// Get int.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get int result.</returns>
    public static int GetInt(List<string> list, int index)
    {
        return int.Parse(list[index]);
    }

    /// <summary>
    /// Get float.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get float result.</returns>
    public static float GetFloat(List<string> list, int index)
    {
        return float.Parse(list[index]);
    }

    /// <summary>
    /// Get long.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get long result.</returns>
    public static long GetLong(List<string> list, int index)
    {
        return long.Parse(list[index]);
    }

    /// <summary>
    /// Get bool MS.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get bool MS result.</returns>
    public static bool GetBoolMS(List<string> list, int index)
    {
        return bool.Parse(list[index]);
    }

    /// <summary>
    /// Get bool.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get bool result.</returns>
    public static bool GetBool(List<string> list, int index)
    {
        return Convert.ToBoolean(list[index]);
    }

    /// <summary>
    /// Get bool s.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get bool s result.</returns>
    public static string GetBoolS(List<string> list, int index)
    {
        return GetBool(list, index) ? "Yes" : "No";
    }

    /// <summary>
    /// Get date time.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get date time result.</returns>
    public static DateTime GetDateTime(List<string> list, int index)
    {
        var dateText = list[index];
        return DateTime.Parse(dateText, CultureInfo.GetCultureInfo("cs"));
    }

    /// <summary>
    /// Get date time s.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get date time s result.</returns>
    public static string GetDateTimeS(List<string> list, int index)
    {
        return DateTime.Parse(list[index].Trim()).ToString();
    }

    /// <summary>
    /// Get image.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get image result.</returns>
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

    /// <summary>
    /// Get decimal.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get decimal result.</returns>
    public static decimal GetDecimal(List<string> list, int index)
    {
        return decimal.Parse(list[index]);
    }

    /// <summary>
    /// Get double.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get double result.</returns>
    public static double GetDouble(List<string> list, int index)
    {
        return double.Parse(list[index]);
    }

    /// <summary>
    /// Get short.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get short result.</returns>
    public static short GetShort(List<string> list, int index)
    {
        return short.Parse(list[index]);
    }

    /// <summary>
    /// Get byte.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get byte result.</returns>
    public static byte GetByte(List<string> list, int index)
    {
        return byte.Parse(list[index]);
    }

    /// <summary>
    /// Get guid.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get guid result.</returns>
    public static Guid GetGuid(List<string> list, int index)
    {
        return Guid.Parse(list[index]);
    }
}
