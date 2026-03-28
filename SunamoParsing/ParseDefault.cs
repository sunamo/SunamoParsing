namespace SunamoParsing;

/// <summary>
/// Provides nested classes for parsing basic types from strings with a default fallback value.
/// </summary>
public class ParseDefault
{
    /// <summary>
    /// Provides byte parsing with default fallback.
    /// </summary>
    public class Byte
    {
        /// <summary>
        /// Parses a byte from a string, returns the default value if parsing fails.
        /// </summary>
        /// <param name="text">The string to parse.</param>
        /// <param name="defaultValue">The default value to return if parsing fails.</param>
        /// <returns>The parsed byte value, or the default value if parsing fails.</returns>
        public byte ParseByte(string text, byte defaultValue)
        {
            if (byte.TryParse(text, out byte result)) return result;
            return defaultValue;
        }
    }

    /// <summary>
    /// Provides integer parsing with default fallback.
    /// </summary>
    public class Integer
    {
        /// <summary>
        /// Parses an integer from a string, returns the default value if parsing fails.
        /// </summary>
        /// <param name="text">The string to parse.</param>
        /// <param name="defaultValue">The default value to return if parsing fails.</param>
        /// <returns>The parsed integer value, or the default value if parsing fails.</returns>
        public int ParseInt(string text, int defaultValue)
        {
            if (int.TryParse(text, out int result)) return result;
            return defaultValue;
        }
    }
}
