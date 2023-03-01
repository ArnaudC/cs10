using System.Runtime.CompilerServices;

namespace CS10;


class CallerArgumentExpressionCustom {
    public static void ValidateArgument(string parameterName, bool condition, [CallerArgumentExpression("condition")] string? message=null)
    {
        if (!condition)
        {
            throw new ArgumentException($"Argument failed validation: <{message}>", parameterName);
        }
    }

    // public void Operation(Action<string> func)
    // {
    //     CallerArgumentExpressionCustom.ValidateArgument(nameof(func), func is not null);
    //     func();
    // }
}
