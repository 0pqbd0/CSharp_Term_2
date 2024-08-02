using ClassicList;

namespace UniqueListImplementation;

/// <summary>
/// Linked list with unique elements
/// </summary>
public class UniqueList : List
{
    /// <summary>
    /// Check whether the value is unique
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    private bool IsUnique(int value)
    {
        ListNode current = head;
        for (int i = 0; i < Size; ++i)
        {
            if (current.Value == value)
            {
                return false;
            }
            current = current.Next;
        }
        return true;
    }

    /// <inheritdoc/>
    /// <exception cref="InvalidOperationValueAlreadyExistsExceptionn"> This collection doesn`t support repeat values </exception>
    public override void Add(int value)
    {
        if (!IsUnique(value))
        {
            throw new InvalidOperationValueAlreadyExistsException("The value already exists in the list!");
        }

        base.Add(value);
    }

    ///<inheritdoc/>
    ///<exception cref="InvalidOperationValueAlreadyExistsExceptionn"> This collection doesn`t support repeat values </exception>
    public override void Replace(int position, int value)
    {
        if (!IsUnique(value))
        {
            throw new InvalidOperationValueAlreadyExistsException("The value already exists in the list.");
        }

        base.Replace(position, value);
    }

    /// <exception cref="InvalidRemoveOperationException"> Collection doesn`t contains element with this value </exception>
    public void RemoveByValue (int value)
    {
        if (IsUnique(value))
        {
            throw new InvalidRemoveOperationException("This value is not in the list!");
        }
        ListNode current = head;

        for (int i = 0; i < Size; ++i)
        {
            if (current.Next.Value == value)
            {
                current.Next = current.Next.Next;
            }
            current = current.Next;
        }
    }

}
