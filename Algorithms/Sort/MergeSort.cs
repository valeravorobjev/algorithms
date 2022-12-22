namespace Algorithms.Sort;

/// <summary>
/// Merge sorting
/// </summary>
public class MergeSort : ISortable
{
    public string Name => nameof(MergeSort);

    public void Sort<T>(T[] items) where T : IComparable<T>
    {
        var result = Merge(items);

        for (int i = 0; i < result.Length; i++)
        {
            items[i] = result[i];
        }
    }

    private T[] Merge<T>(T[] items) where T : IComparable<T>
    {
        if (items.Length < 2)
            return items;

        int half = items.Length / 2 + items.Length % 2;

        T[] left = items[0..half];
        T[] right = items[half..];

        T[] leftItems = Merge(left);
        T[] rightItems = Merge<T>(right);

        T[] result = new T[leftItems.Length + rightItems.Length];

        int n = 0, m = 0, k = 0;

        while (n < leftItems.Length && m < rightItems.Length)
        {
            if (leftItems[n].CompareTo(rightItems[m]) <= 0)
            {
                result[k] = leftItems[n];
                n++;
            }
            else
            {
                result[k] = rightItems[m];
                m++;
            }

            k++;
        }

        while (n < leftItems.Length)
        {
            result[k] = leftItems[n];
            n++;
            k++;
        }

        while (m < rightItems.Length)
        {
            result[k] = rightItems[m];
            m++;
            k++;
        }

        return result;
    }
}