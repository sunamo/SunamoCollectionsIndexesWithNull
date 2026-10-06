namespace SunamoCollectionsIndexesWithNull;

public class CAIndexesWithNull
{
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
