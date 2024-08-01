namespace StackImplementation;

public class StackLinkedList : IStack
{
    private LinkedList<double> list;

    public StackLinkedList()
    {
        list = new LinkedList<double>();
    }

    public void Push(double value)
    {
        list.AddLast(value);
    }

    public double Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Can't pop from empty stack!");
        }

        var lastElem = list.Last.Value;
        list.RemoveLast();
        return lastElem;
    }

    public bool IsEmpty()
    {
        return list.Count == 0;
    }
}
