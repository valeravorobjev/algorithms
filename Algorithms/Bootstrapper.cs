using System.Diagnostics;
using Algorithms.Common;
using Algorithms.DataStructures;
using Algorithms.Sort;

namespace Algorithms;

/// <summary>
/// Class with logic run sort algorithms
/// </summary>
public class Bootstrapper
{
    private readonly List<IPerfom> _perfoms;

    public Bootstrapper()
    {
        _perfoms = new List<IPerfom>
        {
            new SortPerfom(),
            new DataStructurePerfom()
        };
    }
    
    /// <summary>
    /// Run sort algorighms
    /// </summary>
    public void Run()
    {
        Stopwatch stopwatch = new Stopwatch();
        foreach (var perfom in _perfoms)
        {
            stopwatch.Reset();
            
            Debug.WriteLine("");
            Debug.WriteLine($"Group: [{perfom.Name}] [Start]");
            stopwatch.Start();
            perfom.Start();
            stopwatch.Stop();
            Debug.WriteLine($"Group: [{perfom.Name}] [Elasped: {stopwatch.Elapsed}]");
        }
    }
}