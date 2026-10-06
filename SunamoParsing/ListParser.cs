namespace SunamoParsing;

public class ListParser
{
    protected List<string>? list { get; set; }

    #region Methods accepting only index

    protected string GetString(int index)
    {
        if (list!.Count > index) return StaticParse.GetString(list, index);
        return string.Empty;
    }

    protected int GetInt(int index)
    {
        if (list!.Count > index) return StaticParse.GetInt(list, index);
        return 0;
    }

    protected float GetFloat(int index)
    {
        if (list!.Count > index) return StaticParse.GetFloat(list, index);
        return -1;
    }

    protected long GetLong(int index)
    {
        if (list!.Count > index) return StaticParse.GetLong(list, index);
        return -1;
    }

    protected bool GetBoolMS(int index)
    {
        if (list!.Count > index) return StaticParse.GetBoolMS(list, index);
        return false;
    }

    protected bool GetBool(int index)
    {
        if (list!.Count > index) return StaticParse.GetBool(list, index);
        return false;
    }

    protected string GetBoolS(int index)
    {
        if (list!.Count > index) return StaticParse.GetBoolS(list, index);
        return false.ToString();
    }

    protected DateTime GetDateTime(int index)
    {
        if (list!.Count > index) return StaticParse.GetDateTime(list, index);
        return DateTime.MaxValue;
    }

    protected string GetDateTimeS(int index)
    {
        if (list!.Count > index) return StaticParse.GetDateTimeS(list, index);
        return DateTime.MaxValue.ToString();
    }

    protected byte[] GetImage(int index)
    {
        if (list!.Count > index) return StaticParse.GetImage(list, index)!;
        return Array.Empty<byte>();
    }

    protected decimal GetDecimal(int index)
    {
        if (list!.Count > index) return StaticParse.GetDecimal(list, index);
        return -1;
    }

    protected double GetDouble(int index)
    {
        if (list!.Count > index) return StaticParse.GetDouble(list, index);
        return -1;
    }

    protected short GetShort(int index)
    {
        if (list!.Count > index) return StaticParse.GetShort(list, index);
        return -1;
    }

    protected byte GetByte(int index)
    {
        if (list!.Count > index) return StaticParse.GetByte(list, index);
        return 0;
    }

    protected object? GetObject(int index)
    {
        if (list!.Count > index) return list[index];
        return null;
    }

    protected Guid GetGuid(int index)
    {
        if (list!.Count > index) return StaticParse.GetGuid(list, index);
        return Guid.Empty;
    }

    #endregion
}
