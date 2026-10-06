namespace SunamoParsing;

public class ParseDefault
{
    public class Byte
    {
        public byte ParseByte(string text, byte defaultValue)
        {
            if (byte.TryParse(text, out byte result)) return result;
            return defaultValue;
        }
    }

    public class Integer
    {
        public int ParseInt(string text, int defaultValue)
        {
            if (int.TryParse(text, out int result)) return result;
            return defaultValue;
        }
    }
}
