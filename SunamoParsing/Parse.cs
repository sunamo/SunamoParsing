namespace SunamoParsing;

/// <summary>
/// Provides nested classes for parsing basic types from strings.
/// </summary>
public class Parse
{
    /// <summary>
    /// Provides byte parsing functionality.
    /// </summary>
    public class Byte
    {
        /// <summary>
        /// Parses a byte from a string, returns 0 if parsing fails.
        /// </summary>
        /// <param name="text">The string to parse.</param>
        /// <returns>The parsed byte value, or 0 if parsing fails.</returns>
        public byte ParseByte(string text)
        {
            if (byte.TryParse(text, out byte result)) return result;
            return 0;
        }
    }

    /// <summary>
    /// Provides double parsing functionality.
    /// </summary>
    public class Double
    {
        /// <summary>
        /// Parses a double from a string, returns 0 if parsing fails.
        /// </summary>
        /// <param name="text">The string to parse.</param>
        /// <returns>The parsed double value, or 0 if parsing fails.</returns>
        public double ParseDouble(string text)
        {
            if (double.TryParse(text, out double result)) return result;
            return 0;
        }
    }

    /// <summary>
    /// Provides integer parsing functionality.
    /// </summary>
    public class Integer
    {
        /// <summary>
        /// Parses an integer from a string, returns -1 if parsing fails.
        /// </summary>
        /// <param name="text">The string to parse.</param>
        /// <returns>The parsed integer value, or -1 if parsing fails.</returns>
        public int ParseInt(string text)
        {
            if (int.TryParse(text, out int result)) return result;
            return -1;
        }

        /// <summary>
        /// Parses an integer from a string, returns int.MaxValue if parsing fails.
        /// </summary>
        /// <param name="text">The string to parse.</param>
        /// <returns>The parsed integer value, or int.MaxValue if parsing fails.</returns>
        public int ParseIntMaxValue(string text)
        {
            if (int.TryParse(text, out int result)) return result;
            return int.MaxValue;
        }
    }

    /// <summary>
    /// Provides short parsing functionality.
    /// </summary>
    public class Short
    {
        /// <summary>
        /// Parses a short from a string, returns -1 if parsing fails.
        /// </summary>
        /// <param name="text">The string to parse.</param>
        /// <returns>The parsed short value, or -1 if parsing fails.</returns>
        public short ParseShort(string text)
        {
            if (short.TryParse(text, out short result)) return result;
            return -1;
        }
    }
}
