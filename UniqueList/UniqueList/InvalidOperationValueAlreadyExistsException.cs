namespace UniqueListImplementation;

/// <summary>
/// Exception for UniqueList
/// </summary>
public class InvalidOperationValueAlreadyExistsException : InvalidOperationException
{
    public InvalidOperationValueAlreadyExistsException()
    {

    }

    public InvalidOperationValueAlreadyExistsException(string message): base(message) 
    {

    }
}

