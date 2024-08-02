namespace ClassicList;

/// <summary>
/// Linked list realisation
/// </summary>
public class List
{
    /// <summary>
    /// List node realisation
    /// </summary>
    protected class ListNode
    {
        public int Value { get; set; }
        public ListNode? Next { get; set; }
        public ListNode(int value = 0, ListNode? next = null)
        {
            Value = value;
            Next = next;
        }
    }

    public int Size { get; set; }
    protected ListNode? head = null;

    /// <summary>
    /// Add new element in list
    /// </summary>
    /// <param name="value"></param>
    public virtual void Add(int value)
    {
        if (head == null)
        {
            head = new ListNode(value);
        }
        else
        {
            head.Next = new ListNode(value);
        }
        Size++;
    }

    /// <summary>
    /// Remove last element from list
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public void Remove()
    {
        if (Size == 0)
        {
            throw new InvalidOperationException("List is empty");
        }

        if (Size == 1)
        {
            head = null;
        }
        else
        {
            ListNode current = head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
        }
        Size--;
    }

    /// <summary>
    /// Replace elelement in list by position
    /// </summary>
    /// <param name="position"></param>
    /// <param name="value"></param>
    /// <exception cref="IndexOutOfRangeException"></exception>
    public virtual void Replace(int position, int value)
    {
        if (position > Size - 1 || position < 0)
        {
            throw new IndexOutOfRangeException("Invalid position value");
        }
        
        int counter = 0;
        ListNode current = head;
        while (counter < position)
        {
            current = current.Next;
            counter++;
        }
        current.Value = value;
    }
}