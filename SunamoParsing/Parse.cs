namespace SunamoParsing;

public class Parse
{
    public class Byte
    {
        public byte ParseByte(string text)
        {
            if (byte.TryParse(text, out byte result)) return result;
            return 0;
        }
    }

    public class Double
    {
        public double ParseDouble(string text)
        {
            if (double.TryParse(text, out double result)) return result;
            return 0;
        }
    }

    public class Integer
    {
        public int ParseInt(string text)
        {
            if (int.TryParse(text, out int result)) return result;
            return -1;
        }

        public int ParseIntMaxValue(string text)
        {
            if (int.TryParse(text, out int result)) return result;
            return int.MaxValue;
        }
    }

    public class Short
    {
        public short ParseShort(string text)
        {
            if (short.TryParse(text, out short result)) return result;
            return -1;
        }
    }
}
