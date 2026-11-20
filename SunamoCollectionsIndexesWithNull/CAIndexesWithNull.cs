namespace SunamoCollectionsIndexesWithNull;

/// <summary>
/// Represents the CA indexes with null type.
/// </summary>
public class CAIndexesWithNull
{
    /// <summary>
    /// Indexes with null or empty.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns>The indexes with null or empty result.</returns>
    public static List<int> IndexesWithNullOrEmpty(IList list)
    {
        var nullIndexes = new List<int>();
        var currentIndex = 0;
        foreach (var item in list)
        {
            if (item == null)
                nullIndexes.Add(currentIndex);
            else if (item.ToString() == string.Empty) nullIndexes.Add(currentIndex);
            currentIndex++;
        }

        return nullIndexes;
    }

    /// <summary>
    /// Indexes with null.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns>The indexes with null result.</returns>
    public static List<int> IndexesWithNull(IList list)
    {
        var nullIndexes = new List<int>();
        var currentIndex = 0;
        foreach (var item in list)
        {
            if (item == null) nullIndexes.Add(currentIndex);
            currentIndex++;
        }

        return nullIndexes;
    }
}
