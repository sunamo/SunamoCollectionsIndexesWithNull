namespace SunamoCollectionsIndexesWithNull;

public class CAIndexesWithNull
{
    /// <summary>
    ///     Dont trim
    /// </summary>
    /// <param name="items"></param>
    public static List<int> IndexesWithNullOrEmpty(IList items)
    {
        var nullIndexes = new List<int>();
        var i = 0;
        foreach (var item in items)
        {
            if (item == null)
                nullIndexes.Add(i);
            else if (item.ToString() == string.Empty) nullIndexes.Add(i);
            i++;
        }

        return nullIndexes;
    }

    /// <summary>
    ///     For all types
    /// </summary>
    /// <param name="items"></param>
    public static List<int> IndexesWithNull(IList items)
    {
        var nullIndexes = new List<int>();
        var i = 0;
        foreach (var item in items)
        {
            if (item == null) nullIndexes.Add(i);
            i++;
        }

        return nullIndexes;
    }
}