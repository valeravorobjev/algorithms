namespace Algorithms.Sort;

/// <summary>
/// Simple bubble sorting
/// </summary>
public class BubbleSort : ISortable
{
    public void Sort<T>(T[] items) where T : IComparable<T>
    {
        for (int i = 0; i < items.Length; i++)
        {
            for (int j = 0; j < items.Length - i - 1; j++)
            {
                var com = items[j].CompareTo(items[j + 1]);
                if (com > 0)
                {
                    (items[j], items[j + 1]) = (items[j + 1], items[j]);
                }
            }
        }
    }

    public string Name => nameof(BubbleSort);
}

