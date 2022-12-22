using System.Diagnostics;
using Algorithms.Sort;

namespace Algorithms;

/// <summary>
/// Class with logic run sort algorithms
/// </summary>
public class Bootstrapper
{
    private readonly List<ISortable> _sorts;

    public Bootstrapper()
    {
        // Registration sort algorithms
        _sorts = new List<ISortable>();

        _sorts.Add(new BubbleSort());
        _sorts.Add(new MergeSort());
    }

    /// <summary>
    /// Run sort algorighms
    /// </summary>
    public void Run()
    {
        const int ARRAY_LENGTH = 11;

        var items = new int[ARRAY_LENGTH];
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = Random.Shared.Next(0, ARRAY_LENGTH);
        }

        Debug.WriteLine($"Not sorted: {string.Join(',', items)}");

        foreach (var sort in _sorts)
        {
            var array = new int[items.Length];
            items.CopyTo(array, 0);

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine($"Start [{sort.Name}]");
            stopwatch.Start();

            sort.Sort(array);

            stopwatch.Stop();
            Debug.WriteLine($"Sorted [{sort.Name}]: {string.Join(',', array)}");
            Console.WriteLine($"Elasped [{sort.Name}]: {stopwatch.Elapsed}");
            Console.WriteLine();
        }
    }
}