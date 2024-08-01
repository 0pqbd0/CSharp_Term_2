using StackImplementation;

namespace StackPostfixCalculator;

public static class StackCalculator
{
    /// <summary>
    /// Calculates the value of an expression in a postfix record using a stack
    /// </summary>
    /// <param name="postfixExpression"></param>
    /// <param name="stackVersion"></param>
    /// <returns>The result of the calculation</returns>
    /// <exception cref="ArgumentException"></exception>
    public static double Calculating(string postfixExpression, IStack stackVersion)
    {
        if (postfixExpression == null)
        {
            throw new ArgumentNullException("Expression can`t be null!");
        }

        if (postfixExpression.Equals(String.Empty))
        {
            throw new ArgumentException("Expression can`t be empty!");
        }

        var postfixArray = postfixExpression.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var elem in postfixArray)
        {
            if (int.TryParse(elem, out var value))
            {
                stackVersion.Push(value);
            }
            else
            {
                var resultOperation = BinaryOperations.CalculateOperation(stackVersion.Pop(), stackVersion.Pop(), elem);
                stackVersion.Push(resultOperation);
            }
        }

        var result = stackVersion.Pop();
        return stackVersion.IsEmpty() ? result : throw new ArgumentException("Incorrect expression in the postfix entry!");
    }
}