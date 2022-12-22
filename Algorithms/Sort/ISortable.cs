namespace Algorithms.Sort;

/// <summary>
/// Sort interface for all algorithms
/// </summary>
public interface ISortable
{
    /// <summary>
    /// Sort function
    /// </summary>
    /// <typeparam name="T">Type of array elements</typeparam>
    /// <param name="items">Array for sorting</param>
    void Sort<T>(T[] items) where T : IComparable<T>;
    /// <summary>
    /// Algorithm name
    /// </summary>
    string Name { get;}
}

