using System;

namespace Calculator;

public static class CalculatorOperations
{
    private static readonly double delta = 0.0001;

    /// <summary>
    /// All available operations
    /// </summary>
    public enum Operations
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
        ChangeSign
    }

    private static bool IsZero(double value)
    {
        return Math.Abs(value) <= delta;
    }

    /// <summary>
    /// Calculates operations with one operand
    /// </summary>
    /// <param name="operation"></param>
    /// <param name="operand"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static double Calculate(Operations operation, double operand)
    {
        return operation == Operations.ChangeSign 
            ? -operand 
            : throw new ArgumentException("The operation is incorrect");
    }

    /// <summary>
    /// Calculates operations with two operands
    /// </summary>
    /// <param name="operation"></param>
    /// <param name="firstOperand"></param>
    /// <param name="secondOperand"></param>
    /// <returns></returns>
    /// <exception cref="DivideByZeroException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static double Calculate(Operations operation, double firstOperand, double secondOperand)
        => operation switch
           {
               Operations.Addition => firstOperand + secondOperand,
               Operations.Subtraction => firstOperand - secondOperand,
               Operations.Multiplication => firstOperand * secondOperand,
               Operations.Division => IsZero(secondOperand)
                                   ? throw new DivideByZeroException()
                                   : firstOperand / secondOperand,
               _ => throw new ArgumentException("The operation is incorrect")
           };

 }
