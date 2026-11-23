namespace SunamoParsing;

/// <summary>
/// Represents the parse default type.
/// </summary>
public class ParseDefault
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
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The parse byte result.</returns>
        public byte ParseByte(string text, byte defaultValue)
        {
            if (byte.TryParse(text, out byte result)) return result;
            return defaultValue;
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
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The parse int result.</returns>
        public int ParseInt(string text, int defaultValue)
        {
            if (int.TryParse(text, out int result)) return result;
            return defaultValue;
        }
    }
}
