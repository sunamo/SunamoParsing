namespace SunamoParsing;

/// <summary>
/// Represents the list parser type.
/// </summary>
public class ListParser
{
    /// <summary>
    /// Gets or sets the list.
    /// </summary>
    protected List<string>? list { get; set; }

    #region Methods accepting only index

    /// <summary>
    /// Get string.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The get string result.</returns>
    protected string GetString(int index)
    {
        if (list!.Count > index) return StaticParse.GetString(list, index);
        return string.Empty;
    }

    /// <summary>
    /// Get int.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The get int result.</returns>
    protected int GetInt(int index)
    {
        if (list!.Count > index) return StaticParse.GetInt(list, index);
        return 0;
    }

    /// <summary>
    /// Get float.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The get float result.</returns>
    protected float GetFloat(int index)
    {
        if (list!.Count > index) return StaticParse.GetFloat(list, index);
        return -1;
    }

    /// <summary>
    /// Get long.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The get long result.</returns>
    protected long GetLong(int index)
    {
        if (list!.Count > index) return StaticParse.GetLong(list, index);
        return -1;
    }

    /// <summary>
    /// Get bool MS.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The get bool MS result.</returns>
    protected bool GetBoolMS(int index)
    {
        if (list!.Count > index) return StaticParse.GetBoolMS(list, index);
        return false;
    }

    /// <summary>
    /// Get bool.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The get bool result.</returns>
    protected bool GetBool(int index)
    {
        if (list!.Count > index) return StaticParse.GetBool(list, index);
        return false;
    }

    /// <summary>
    /// Get bool s.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The get bool s result.</returns>
    protected string GetBoolS(int index)
    {
        if (list!.Count > index) return StaticParse.GetBoolS(list, index);
        return false.ToString();
    }

    /// <summary>
    /// Get date time.
    /// </summary>
    /// <returns>The get date time result.</returns>
    protected DateTime GetDateTime(int index)
    {
        if (list!.Count > index) return StaticParse.GetDateTime(list, index);
        return DateTime.MaxValue;
    }

    /// <summary>
    /// Get date time s.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The get date time s result.</returns>
    protected string GetDateTimeS(int index)
    {
        if (list!.Count > index) return StaticParse.GetDateTimeS(list, index);
        return DateTime.MaxValue.ToString();
    }

    /// <summary>
    /// Get image.
    /// </summary>
    /// <returns>The get image result.</returns>
    protected byte[] GetImage(int index)
    {
        if (list!.Count > index) return StaticParse.GetImage(list, index)!;
        return Array.Empty<byte>();
    }

    /// <summary>
    /// Get decimal.
    /// </summary>
    /// <typeparam name="byte">The type byte.</typeparam>
    /// <returns>The get decimal result.</returns>
    protected decimal GetDecimal(int index)
    {
        if (list!.Count > index) return StaticParse.GetDecimal(list, index);
        return -1;
    }

    /// <summary>
    /// Get double.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The get double result.</returns>
    protected double GetDouble(int index)
    {
        if (list!.Count > index) return StaticParse.GetDouble(list, index);
        return -1;
    }

    /// <summary>
    /// Get short.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The get short result.</returns>
    protected short GetShort(int index)
    {
        if (list!.Count > index) return StaticParse.GetShort(list, index);
        return -1;
    }

    /// <summary>
    /// Get byte.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The get byte result.</returns>
    protected byte GetByte(int index)
    {
        if (list!.Count > index) return StaticParse.GetByte(list, index);
        return 0;
    }

    /// <summary>
    /// Get object.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The get object result.</returns>
    protected object? GetObject(int index)
    {
        if (list!.Count > index) return list[index];
        return null;
    }

    /// <summary>
    /// Get guid.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The get guid result.</returns>
    protected Guid GetGuid(int index)
    {
        if (list!.Count > index) return StaticParse.GetGuid(list, index);
        return Guid.Empty;
    }

    #endregion
}
