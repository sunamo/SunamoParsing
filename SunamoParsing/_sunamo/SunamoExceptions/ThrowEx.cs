namespace SunamoParsing._sunamo.SunamoExceptions;

/// <summary>
/// Provides methods for throwing exceptions with diagnostic information.
/// </summary>
internal partial class ThrowEx
{
    /// <summary>
    /// Throws a "not implemented" exception with the calling method's full name.
    /// </summary>
    /// <returns>True if an exception was thrown.</returns>
    internal static bool NotImplementedMethod() { return ThrowIsNotNull(Exceptions.NotImplementedMethod); }

    /// <summary>
    /// Gets the full name (type.method) of the currently executing code.
    /// </summary>
    /// <returns>The full name string in format "Namespace.Type.Method".</returns>
    internal static string FullNameOfExecutedCode()
    {
        Tuple<string, string, string> placeOfException = Exceptions.PlaceOfException();
        string fullName = FullNameOfExecutedCode(placeOfException.Item1, placeOfException.Item2, true);
        return fullName;
    }

    /// <summary>
    /// Gets the full name (type.method) from provided type and method name.
    /// </summary>
    /// <param name="type">The type object (Type, MethodBase, string, or any object).</param>
    /// <param name="methodName">The method name, or null to detect automatically.</param>
    /// <param name="isFromThrowEx">Whether the call originates from ThrowEx (adjusts stack depth).</param>
    /// <returns>The full name string in format "Namespace.Type.Method".</returns>
    static string FullNameOfExecutedCode(object type, string methodName, bool isFromThrowEx = false)
    {
        if (methodName == null)
        {
            int depth = 2;
            if (isFromThrowEx)
            {
                depth++;
            }

            methodName = Exceptions.CallingMethod(depth);
        }
        string typeFullName;
        if (type is Type typeInstance)
        {
            typeFullName = typeInstance.FullName ?? "Type cannot be get via type is Type typeInstance";
        }
        else if (type is MethodBase method)
        {
            typeFullName = method.ReflectedType?.FullName ?? "Type cannot be get via type is MethodBase method";
            methodName = method.Name;
        }
        else if (type is string)
        {
            typeFullName = type.ToString() ?? "Type cannot be get via type is string";
        }
        else
        {
            Type resolvedType = type.GetType();
            typeFullName = resolvedType.FullName ?? "Type cannot be get via type.GetType()";
        }
        return string.Concat(typeFullName, ".", methodName);
    }

    /// <summary>
    /// Throws an exception if the provided exception message is not null.
    /// </summary>
    /// <param name="exception">The exception message to check.</param>
    /// <param name="isReallyThrowing">Whether to actually throw the exception or just break in debugger.</param>
    /// <returns>True if the exception message was not null.</returns>
    internal static bool ThrowIsNotNull(string? exception, bool isReallyThrowing = true)
    {
        if (exception != null)
        {
            Debugger.Break();
            if (isReallyThrowing)
            {
                throw new Exception(exception);
            }
            return true;
        }
        return false;
    }

    /// <summary>
    /// Invokes a function to generate an exception message with the calling method's full name,
    /// then throws if the result is not null.
    /// </summary>
    /// <param name="exceptionFactory">The function that generates an exception message from a method name.</param>
    /// <returns>True if an exception was thrown.</returns>
    internal static bool ThrowIsNotNull(Func<string, string?> exceptionFactory)
    {
        string? exception = exceptionFactory(FullNameOfExecutedCode());
        return ThrowIsNotNull(exception);
    }
}
