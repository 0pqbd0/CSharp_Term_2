using System.ComponentModel;
using System.Windows.Forms;

namespace Calculator;

public class Calculator : INotifyPropertyChanged
{
    private const string errorMessage = "Error";
    private readonly HashSet<string> acceptableOperations = new HashSet<string> { "+", "-", "*", "/", "+/-" };

    private enum CalculatorStates
    {
        ProcessingTheOperation,
        ProcessingTheValue
    }

    private string displayedMessage = "0";
    private double result = 0;
    private double tempValue = 0;

    private CalculatorStates state = CalculatorStates.ProcessingTheValue;
    private CalculatorOperations.Operations operation = CalculatorOperations.Operations.Addition;

    /// <summary>
    /// Event for data binding with user
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    /// <summary>
    /// Property that notifies of its change
    /// </summary>
    public string Message
    {
        get
        {
            return displayedMessage;
        }

        private set
        {
            displayedMessage = value;
            OnPropertyChanged("Message");
            
        }
    }

    /// <summary>
    /// Add digit on the right
    /// </summary>
    /// <param name="digit"></param>
    public void AddDigit(char digit)
    {
        if (!char.IsDigit(digit))
        {
            Message = errorMessage;
        }

        else
        {
            if (state == CalculatorStates.ProcessingTheOperation)
            {
                state = CalculatorStates.ProcessingTheValue;
            }

            tempValue = Math.Sign(tempValue) >= 0
                ? tempValue * 10 + (digit - '0')
                : tempValue * 10 - (digit - '0');
            Message = tempValue.ToString();
        }
    }

    /// <summary>
    /// Adds a new operation and evaluates the previous one if it exists
    /// </summary>
    /// <param name="newOperation"></param>
    public void AddOperation(string newOperation)
    {
        if (!acceptableOperations.Contains(newOperation))
        {
            Message = errorMessage;
        }
        else if (newOperation.Equals("+/-"))
        {
            if (state == CalculatorStates.ProcessingTheOperation)
            {
                result = (CalculatorOperations.Calculate(CalculatorOperations.Operations.ChangeSign, result));
                Message = Math.Round(result, 7).ToString();
            }
            else
            {
                tempValue = CalculatorOperations.Calculate(CalculatorOperations.Operations.ChangeSign, tempValue);
                Message = Math.Round(tempValue, 7).ToString();
            }
        }
        else
        {
            if (state == CalculatorStates.ProcessingTheValue)
            {
                try
                {
                    result = CalculatorOperations.Calculate(operation, result, tempValue); 
                    tempValue = 0;
                    Message = result.ToString();
                }
                catch (DivideByZeroException)
                {
                    Message = errorMessage;
                }
            }
            state = CalculatorStates.ProcessingTheOperation;
            operation = newOperation switch
            {
                "+" => CalculatorOperations.Operations.Addition,
                "-" => CalculatorOperations.Operations.Subtraction,
                "*" => CalculatorOperations.Operations.Multiplication,
                "/" => CalculatorOperations.Operations.Division,
                _ => CalculatorOperations.Operations.Addition
            };
        }
    }

    /// <summary>
    /// Calculates current operation
    /// </summary>
    public void Calculate()
    {
        try
        {
            result = CalculatorOperations.Calculate(operation, result, tempValue);
            Message = Math.Round(result, 7).ToString();
            tempValue = 0;
            state = CalculatorStates.ProcessingTheOperation;
            operation = CalculatorOperations.Operations.Addition;
        }
        catch (Exception ex) when (ex is AggregateException || ex is DivideByZeroException)
        {
            Message = errorMessage;
        }
    }

    /// <summary>
    /// Returns the calculator to its initial state
    /// </summary>
    public void Clear()
    {
        result = 0;
        tempValue = 0;
        state = CalculatorStates.ProcessingTheValue;
        operation = CalculatorOperations.Operations.Addition;
        Message = "0";
    }
}
