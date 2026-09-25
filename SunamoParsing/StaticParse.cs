namespace SunamoParsing;

/// <summary>
/// Provides static methods for parsing values from a list of strings by index.
/// </summary>
public static class StaticParse
{
    /// <summary>
    /// Gets a trimmed string value from the list at the specified index.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to retrieve.</param>
    /// <returns>The trimmed string value at the specified index.</returns>
    public static string GetString(List<string> list, int index)
    {
        var result = list[index];
        return result.TrimEnd(' ');
    }

    /// <summary>
    /// Parses an integer value from the list at the specified index.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to parse.</param>
    /// <returns>The parsed integer value.</returns>
    public static int GetInt(List<string> list, int index)
    {
        return int.Parse(list[index]);
    }

    /// <summary>
    /// Parses a float value from the list at the specified index.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to parse.</param>
    /// <returns>The parsed float value.</returns>
    public static float GetFloat(List<string> list, int index)
    {
        return float.Parse(list[index]);
    }

    /// <summary>
    /// Parses a long value from the list at the specified index.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to parse.</param>
    /// <returns>The parsed long value.</returns>
    public static long GetLong(List<string> list, int index)
    {
        return long.Parse(list[index]);
    }

    /// <summary>
    /// Parses a boolean value using bool.Parse from the list at the specified index.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to parse.</param>
    /// <returns>The parsed boolean value.</returns>
    public static bool GetBoolMS(List<string> list, int index)
    {
        return bool.Parse(list[index]);
    }

    /// <summary>
    /// Converts a value to boolean using Convert.ToBoolean from the list at the specified index.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to convert.</param>
    /// <returns>The converted boolean value.</returns>
    public static bool GetBool(List<string> list, int index)
    {
        return Convert.ToBoolean(list[index]);
    }

    /// <summary>
    /// Gets a "Yes" or "No" string representation of a boolean value from the list at the specified index.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to convert.</param>
    /// <returns>"Yes" if the value is true, "No" otherwise.</returns>
    public static string GetBoolS(List<string> list, int index)
    {
        return GetBool(list, index) ? "Yes" : "No";
    }

    /// <summary>
    /// Parses a DateTime value in Czech culture format from the list at the specified index.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to parse.</param>
    /// <returns>The parsed DateTime value.</returns>
    public static DateTime GetDateTime(List<string> list, int index)
    {
        var dateText = list[index];
        return DateTime.Parse(dateText, CultureInfo.GetCultureInfo("cs"));
    }

    /// <summary>
    /// Parses a DateTime and returns its string representation from the list at the specified index.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to parse.</param>
    /// <returns>The string representation of the parsed DateTime.</returns>
    public static string GetDateTimeS(List<string> list, int index)
    {
        return DateTime.Parse(list[index].Trim()).ToString();
    }

    /// <summary>
    /// Gets an image as a byte array from the list at the specified index.
    /// Returns null if the value is DBNull.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to retrieve.</param>
    /// <returns>The byte array representing the image, or null if DBNull.</returns>
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
    /// Parses a decimal value from the list at the specified index.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to parse.</param>
    /// <returns>The parsed decimal value.</returns>
    public static decimal GetDecimal(List<string> list, int index)
    {
        return decimal.Parse(list[index]);
    }

    /// <summary>
    /// Parses a double value from the list at the specified index.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to parse.</param>
    /// <returns>The parsed double value.</returns>
    public static double GetDouble(List<string> list, int index)
    {
        return double.Parse(list[index]);
    }

    /// <summary>
    /// Parses a short value from the list at the specified index.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to parse.</param>
    /// <returns>The parsed short value.</returns>
    public static short GetShort(List<string> list, int index)
    {
        return short.Parse(list[index]);
    }

    /// <summary>
    /// Parses a byte value from the list at the specified index.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to parse.</param>
    /// <returns>The parsed byte value.</returns>
    public static byte GetByte(List<string> list, int index)
    {
        return byte.Parse(list[index]);
    }

    /// <summary>
    /// Parses a Guid value from the list at the specified index.
    /// </summary>
    /// <param name="list">The list of strings to parse from.</param>
    /// <param name="index">The index of the element to parse.</param>
    /// <returns>The parsed Guid value.</returns>
    public static Guid GetGuid(List<string> list, int index)
    {
        return Guid.Parse(list[index]);
    }
}
