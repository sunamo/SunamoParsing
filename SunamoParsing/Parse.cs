namespace SunamoParsing;

/// <summary>
/// Represents the parse type.
/// </summary>
public class Parse
{
    /// <summary>
    /// Represents the byte type.
    /// </summary>
    public class Byte
    {
        /// <summary>
        /// Parse byte.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The parse byte result.</returns>
        public byte ParseByte(string text)
        {
            if (byte.TryParse(text, out byte result)) return result;
            return 0;
        }
    }

    /// <summary>
    /// Represents the double type.
    /// </summary>
    public class Double
    {
        /// <summary>
        /// Parse double.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The parse double result.</returns>
        public double ParseDouble(string text)
        {
            if (double.TryParse(text, out double result)) return result;
            return 0;
        }
    }

    /// <summary>
    /// Represents the integer type.
    /// </summary>
    public class Integer
    {
        /// <summary>
        /// Parse int.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The parse int result.</returns>
        public int ParseInt(string text)
        {
            if (int.TryParse(text, out int result)) return result;
            return -1;
        }

        /// <summary>
        /// Parse int max value.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The parse int max value result.</returns>
        public int ParseIntMaxValue(string text)
        {
            if (int.TryParse(text, out int result)) return result;
            return int.MaxValue;
        }
    }

    /// <summary>
    /// Represents the short type.
    /// </summary>
    public class Short
    {
        /// <summary>
        /// Parse short.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The parse short result.</returns>
        public short ParseShort(string text)
        {
            if (short.TryParse(text, out short result)) return result;
            return -1;
        }
    }
}
