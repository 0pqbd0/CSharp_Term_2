namespace UniqueListImplementation;
/// <summary>
/// Indicates the absence of an element in the collection.
/// </summary>
internal class InvalidRemoveOperationException : InvalidOperationException
{
    public InvalidRemoveOperationException()
    {

    }

    public InvalidRemoveOperationException(string message) : base(message)
    {

    }
}
