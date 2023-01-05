using System.Diagnostics;

namespace Algorithms.DataStructures.Perfoms;

/// <summary>
/// Implementation IPerfom for testing data structure LinkedList
/// </summary>
public class LinkedListPerfom: IPerfom
{
    /// <summary>
    /// Perfom data structure
    /// </summary>
    public void Perfom()
    {
        LinkedList<int> linkedList = new LinkedList<int>();
        foreach (var item in Enumerable.Range(0, 10))
        {
            linkedList.Add(item);
        }

        linkedList.Remove(5);

        foreach (var item in linkedList)
        {
            Debug.WriteLine(item);
        }
    }
}