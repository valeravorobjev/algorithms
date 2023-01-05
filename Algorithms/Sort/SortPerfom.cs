using System.Diagnostics;
using Algorithms.Common;

namespace Algorithms.Sort;

public class SortPerfom : IPerfom
{
    private readonly List<ISortable> _sorts;

    public SortPerfom()
    {
        // Registration sort algorithms
        _sorts = new List<ISortable>
        {
            new BubbleSort(),
            new MergeSort()
        };
    }
    
    public void Start()
    {
        const int arrayLength = 1000;

        var items = new int[arrayLength];
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = Random.Shared.Next(0, arrayLength);
        }

        Debug.WriteLine($"Not sorted: {string.Join(',', items)}");

        foreach (var sort in _sorts)
        {
            var array = new int[items.Length];
            items.CopyTo(array, 0);

            Stopwatch stopwatch = new Stopwatch();
            Debug.WriteLine($"Start [{sort.Name}]");
            stopwatch.Start();

            sort.Sort(array);

            stopwatch.Stop();
            Debug.WriteLine($"Sorted [{sort.Name}]: {string.Join(',', array)}");
            Debug.WriteLine($"Elasped [{sort.Name}]: {stopwatch.Elapsed}");
        }
    }

    public string Name => "Sort";
}