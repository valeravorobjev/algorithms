using System.Collections;

namespace Algorithms.DataStructures;

/// <summary>
/// The linked list data struct implimentation
/// </summary>
public class LinkedList<T>: ICollection<T>
{
    /// <summary>
    /// First (head) element in linked list
    /// </summary>
    private Node<T>? FirstNode { get; set; }
    /// <summary>
    /// Last (end) element in linked list
    /// </summary>
    private Node<T>? LastNode { get; set; }
    
    public IEnumerator<T> GetEnumerator()
    {
        Node<T>? current = FirstNode;
        while (current != null)
        {
            yield return current.Item;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    /// Add new element to linked list
    /// </summary>
    /// <param name="item">The item for add to linked list</param>
    public void Add(T item)
    {
        Node<T> node = new Node<T>(item);
        if (FirstNode is null)
            FirstNode = node;
        else
            LastNode!.Next = node;

        LastNode = node;

        Count++;
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
        Node<T>? current = FirstNode;
        Node<T>? previous = null;

        while (current != null)
        {
            if (current.Item!.Equals(item))
            {
                if (previous != null)
                {
                    previous.Next = current.Next;
                    if (current.Next is null)
                    {
                        LastNode = previous;
                    }
                }
                else
                {
                    FirstNode = FirstNode!.Next;
                    if (FirstNode == null)
                    {
                        LastNode = null;
                    }
                }

                Count--;
                return true;
            }

            previous = current;
            current = current.Next;
        }

        return false;
    }

    public int Count { get; private set; }
    public bool IsReadOnly { get; }
}

/// <summary>
/// Node of linked
/// </summary>
/// <typeparam name="T"></typeparam>
public class Node<T>
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="item">The item for node</param>
    public Node(T item)
    {
        Item = item;
    }

    /// <summary>
    /// Node's item
    /// </summary>
    public T Item { get; set; }
    /// <summary>
    /// Next node
    /// </summary>
    public Node<T>? Next { get; set; }
}