namespace StackImplementation;

public class StackDynamicArray : IStack
{
    private List<double> array;

    public StackDynamicArray()
    {
        array = new List<double>();
    }

    public void Push(double value)
    {
        array.Add(value);
    }

    public double Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Can't pop from empty stack!");
        }

        var lastElem = array[array.Count - 1];
        array.RemoveAt(array.Count - 1);
        return lastElem;
    }

    public bool IsEmpty()
    {
        return array.Count == 0;
    }
}
