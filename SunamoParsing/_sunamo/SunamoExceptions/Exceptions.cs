namespace SunamoParsing._sunamo.SunamoExceptions;

/// <summary>
/// Provides helper methods for exception handling and diagnostics.
/// </summary>
internal sealed partial class Exceptions
{
    /// <summary>
    /// Formats a prefix string for exception messages.
    /// </summary>
    /// <param name="before">The prefix to prepend, or null/whitespace to return empty.</param>
    /// <returns>The formatted prefix with ": " appended, or empty string.</returns>
    internal static string CheckBefore(string before)
    {
        return string.IsNullOrWhiteSpace(before) ? string.Empty : before + ": ";
    }

    /// <summary>
    /// Retrieves the type name, method name, and full stack trace of the calling code.
    /// </summary>
    /// <param name="isFillAlsoFirstTwo">Whether to also extract type and method name from the first non-ThrowEx frame.</param>
    /// <returns>A tuple containing (typeName, methodName, stackTraceText).</returns>
    internal static Tuple<string, string, string> PlaceOfException(bool isFillAlsoFirstTwo = true)
    {
        StackTrace stackTrace = new();
        var stackTraceText = stackTrace.ToString();
        var lines = stackTraceText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
        lines.RemoveAt(0);
        string typeName = string.Empty;
        string methodName = string.Empty;
        for (int i = 0; i < lines.Count; i++)
        {
            var item = lines[i];
            if (isFillAlsoFirstTwo)
                if (!item.StartsWith("   at ThrowEx"))
                {
                    TypeAndMethodName(item, out typeName, out methodName);
                    isFillAlsoFirstTwo = false;
                }
            if (item.StartsWith("at System."))
            {
                lines.Add(string.Empty);
                lines.Add(string.Empty);
                break;
            }
        }
        return new Tuple<string, string, string>(typeName, methodName, string.Join(Environment.NewLine, lines));
    }

    /// <summary>
    /// Extracts the type name and method name from a stack trace line.
    /// </summary>
    /// <param name="line">The stack trace line to parse.</param>
    /// <param name="typeName">The extracted type name.</param>
    /// <param name="methodName">The extracted method name.</param>
    internal static void TypeAndMethodName(string line, out string typeName, out string methodName)
    {
        var callerText = line.Split("at ")[1].Trim();
        var fullName = callerText.Split("(")[0];
        var parts = fullName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        methodName = parts[^1];
        parts.RemoveAt(parts.Count - 1);
        typeName = string.Join(".", parts);
    }

    /// <summary>
    /// Gets the name of the calling method at the specified stack depth.
    /// </summary>
    /// <param name="depth">The stack frame depth to retrieve the method name from.</param>
    /// <returns>The method name, or an error message if it cannot be retrieved.</returns>
    internal static string CallingMethod(int depth = 1)
    {
        StackTrace stackTrace = new();
        var methodBase = stackTrace.GetFrame(depth)?.GetMethod();
        if (methodBase == null)
        {
            return "Method name cannot be get";
        }
        var methodName = methodBase.Name;
        return methodName;
    }

    /// <summary>
    /// Formats a "not implemented method" exception message with an optional prefix.
    /// </summary>
    /// <param name="before">The prefix to prepend to the message.</param>
    /// <returns>The formatted exception message.</returns>
    internal static string? NotImplementedMethod(string before)
    {
        return CheckBefore(before) + "Not implemented method.";
    }
}
