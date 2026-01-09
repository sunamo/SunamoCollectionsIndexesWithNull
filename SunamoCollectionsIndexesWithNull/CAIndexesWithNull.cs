// variables names: ok
namespace SunamoCollectionsIndexesWithNull;

/// <summary>
/// Provides utility methods for finding indexes of null or empty elements in collections
/// </summary>
public class CAIndexesWithNull
{
    /// <summary>
    /// Returns a list of indexes where elements are either null or empty strings
    /// </summary>
    /// <param name="list">The collection to search for null or empty elements</param>
    /// <returns>A list of indexes where elements are null or have empty string representation</returns>
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
    /// Returns a list of indexes where elements are null
    /// </summary>
    /// <param name="list">The collection to search for null elements</param>
    /// <returns>A list of indexes where elements are null</returns>
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