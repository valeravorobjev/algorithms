using System.Diagnostics;
using Algorithms.Common;

namespace Algorithms.DataStructures;

/// <summary>
/// Implementation IPerfom for testing data structure LinkedList
/// </summary>
public class DataStructurePerfom: IPerfom
{
    /// <summary>
    /// Perfom data structure
    /// </summary>
    public void Start()
    {
        LinkedList<int> linkedList = new LinkedList<int>();
        foreach (var item in Enumerable.Range(0, 10))
        {
            linkedList.Add(item);
        }

        bool ok = linkedList.Contains(10);
        linkedList.Clear();

        foreach (var item in linkedList)
        {
            Debug.WriteLine(item);
        }
    }

    public string Name => "DataStructure";
}