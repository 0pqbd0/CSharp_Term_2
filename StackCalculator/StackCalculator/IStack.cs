namespace StackImplementation;
public interface IStack
{
    /// <summary>
    /// Adds a new element to the stack with the passed value
    /// </summary>
    /// <param name="value"></param>
    public void Push(double value);

    /// <summary>
    /// Deletes a stack element by returning its value
    /// </summary>
    /// <returns>the value of the deleted element</returns>
    public double Pop();

    /// <summary>
    /// Checks if the stack is empty
    /// </summary>
    /// <returns>True if empty and false if not empty</returns>
    public bool IsEmpty();

}