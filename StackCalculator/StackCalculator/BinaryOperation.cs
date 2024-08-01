namespace StackPostfixCalculator;

public static class BinaryOperations
{
    private static double delta = 1e-9;

    /// <summary>
    /// Calculates the result of an operation between two operands
    /// </summary>
    /// <param name="firstOperand"></param>
    /// <param name="secondOperand"></param>
    /// <param name="binaryOperator"></param>
    /// <returns>The result of the calculation</returns>
    /// <exception cref="DivideByZeroException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    public static double CalculateOperation(double firstOperand, double secondOperand, string binaryOperator)
    {
        switch (binaryOperator)
        {
            case "+":
                return firstOperand + secondOperand;

            case "-":
                return secondOperand - firstOperand;

            case "*":
                return firstOperand * secondOperand;

            case "/":
                if (Math.Abs(firstOperand) < delta)
                {
                    throw new DivideByZeroException("The second operand is zero. Can't be devided by zero!");
                }
                return secondOperand / firstOperand;

            default:
                throw new InvalidOperationException("Incorrect character!");
        }
    }
}