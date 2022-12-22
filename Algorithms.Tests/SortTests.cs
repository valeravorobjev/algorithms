using Algorithms.Sort;

namespace Algorithms.Tests;

public class SortTests
{
    [Fact]
    public void BubbleSortTest()
    {
        var exs = new int [11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        var values = new int[11] { 11, 2, 5, 7, 1, 10, 3, 8, 4, 9, 6 };

        BubbleSort bubbleSort = new BubbleSort();
        bubbleSort.Sort(values);

        for (int i = 0; i < values.Length; i++)
        {
            Assert.Equal(exs[i], values[i]);
        }
    }
    
    [Fact]
    public void MergeSortTest()
    {
        var exs = new int [11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        var values = new int[11] { 11, 2, 5, 7, 1, 10, 3, 8, 4, 9, 6 };

        MergeSort mergeSort = new MergeSort();
        mergeSort.Sort(values);

        for (int i = 0; i < values.Length; i++)
        {
            Assert.Equal(exs[i], values[i]);
        }
    }
}