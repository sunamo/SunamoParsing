namespace SunamoParsing;

/// <summary>
/// Base class for parsing values from a list of strings by index.
/// </summary>
public class ListParser
{
    /// <summary>
    /// The list of strings to parse values from.
    /// </summary>
    protected List<string>? list { get; set; }

    #region Methods accepting only index

    /// <summary>
    /// Gets a string value at the specified index, or empty string if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The string value, or empty string if index is out of range.</returns>
    protected string GetString(int index)
    {
        if (list!.Count > index) return StaticParse.GetString(list, index);
        return string.Empty;
    }

    /// <summary>
    /// Gets an integer value at the specified index, or 0 if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The integer value, or 0 if out of range.</returns>
    protected int GetInt(int index)
    {
        if (list!.Count > index) return StaticParse.GetInt(list, index);
        return 0;
    }

    /// <summary>
    /// Gets a float value at the specified index, or -1 if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The float value, or -1 if out of range.</returns>
    protected float GetFloat(int index)
    {
        if (list!.Count > index) return StaticParse.GetFloat(list, index);
        return -1;
    }

    /// <summary>
    /// Gets a long value at the specified index, or -1 if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The long value, or -1 if out of range.</returns>
    protected long GetLong(int index)
    {
        if (list!.Count > index) return StaticParse.GetLong(list, index);
        return -1;
    }

    /// <summary>
    /// Gets a boolean value using bool.Parse at the specified index, or false if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The boolean value, or false if out of range.</returns>
    protected bool GetBoolMS(int index)
    {
        if (list!.Count > index) return StaticParse.GetBoolMS(list, index);
        return false;
    }

    /// <summary>
    /// Gets a boolean value using Convert.ToBoolean at the specified index, or false if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The boolean value, or false if out of range.</returns>
    protected bool GetBool(int index)
    {
        if (list!.Count > index) return StaticParse.GetBool(list, index);
        return false;
    }

    /// <summary>
    /// Gets a "Yes"/"No" string for a boolean value at the specified index, or "False" if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>"Yes" or "No", or "False" if out of range.</returns>
    protected string GetBoolS(int index)
    {
        if (list!.Count > index) return StaticParse.GetBoolS(list, index);
        return false.ToString();
    }

    /// <summary>
    /// Gets a DateTime value at the specified index, or DateTime.MaxValue if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The DateTime value, or DateTime.MaxValue if out of range.</returns>
    protected DateTime GetDateTime(int index)
    {
        if (list!.Count > index) return StaticParse.GetDateTime(list, index);
        return DateTime.MaxValue;
    }

    /// <summary>
    /// Gets a DateTime as string at the specified index, or DateTime.MaxValue string if out of range.
    /// May return null equivalent when value equals DBNull.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The DateTime string, or DateTime.MaxValue string if out of range.</returns>
    protected string GetDateTimeS(int index)
    {
        if (list!.Count > index) return StaticParse.GetDateTimeS(list, index);
        return DateTime.MaxValue.ToString();
    }

    /// <summary>
    /// Gets an image byte array at the specified index, or empty array if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The byte array, or empty array if out of range.</returns>
    protected byte[] GetImage(int index)
    {
        if (list!.Count > index) return StaticParse.GetImage(list, index)!;
        return Array.Empty<byte>();
    }

    /// <summary>
    /// Gets a decimal value at the specified index, or -1 if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The decimal value, or -1 if out of range.</returns>
    protected decimal GetDecimal(int index)
    {
        if (list!.Count > index) return StaticParse.GetDecimal(list, index);
        return -1;
    }

    /// <summary>
    /// Gets a double value at the specified index, or -1 if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The double value, or -1 if out of range.</returns>
    protected double GetDouble(int index)
    {
        if (list!.Count > index) return StaticParse.GetDouble(list, index);
        return -1;
    }

    /// <summary>
    /// Gets a short value at the specified index, or -1 if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The short value, or -1 if out of range.</returns>
    protected short GetShort(int index)
    {
        if (list!.Count > index) return StaticParse.GetShort(list, index);
        return -1;
    }

    /// <summary>
    /// Gets a byte value at the specified index, or 0 if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The byte value, or 0 if out of range.</returns>
    protected byte GetByte(int index)
    {
        if (list!.Count > index) return StaticParse.GetByte(list, index);
        return 0;
    }

    /// <summary>
    /// Gets an object at the specified index, or null if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The object, or null if out of range.</returns>
    protected object? GetObject(int index)
    {
        if (list!.Count > index) return list[index];
        return null;
    }

    /// <summary>
    /// Gets a Guid value at the specified index, or Guid.Empty if out of range.
    /// </summary>
    /// <param name="index">The index to retrieve from.</param>
    /// <returns>The Guid value, or Guid.Empty if out of range.</returns>
    protected Guid GetGuid(int index)
    {
        if (list!.Count > index) return StaticParse.GetGuid(list, index);
        return Guid.Empty;
    }

    #endregion
}
