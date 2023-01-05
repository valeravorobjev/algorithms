using System.Collections;
using System.Diagnostics;
using Algorithms.DataStructures.Perfoms;
using Algorithms.Sort;

namespace Algorithms;

/// <summary>
/// Class with logic run sort algorithms
/// </summary>
public class Bootstrapper
{
    private readonly List<ISortable> _sorts;
    private readonly List<IPerfom> _perfoms;

    public Bootstrapper()
    {
        // Registration sort algorithms
        _sorts = new List<ISortable>
        {
            new BubbleSort(),
            new MergeSort()
        };
        
        _perfoms = new List<IPerfom>
        {
            new LinkedListPerfom()
        };
    }

    /// <summary>
    /// Perfom data structures
    /// </summary>
    public void RunPerfom()
    {
        foreach (var prefom in _perfoms)
        {
            prefom.Perfom();
        }
    }

    /// <summary>
    /// Run sort algorighms
    /// </summary>
    public void SortsRun()
    {
        const int arrayLength = 100000;

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