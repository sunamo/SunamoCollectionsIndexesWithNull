// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoCollectionsIndexesWithNull;

public class CAIndexesWithNull
{
    /// <summary>
    ///     Dont trim
    /// </summary>
    /// <param name="times"></param>
    public static List<int> IndexesWithNullOrEmpty(IList times)
    {
        var nulled = new List<int>();
        var i = 0;
        foreach (var item in times)
        {
            if (item == null)
                nulled.Add(i);
            else if (item.ToString() == string.Empty) nulled.Add(i);
            i++;
        }

        return nulled;
    }

    /// <summary>
    ///     For all types
    /// </summary>
    /// <param name="times"></param>
    public static List<int> IndexesWithNull(IList times)
    {
        var nulled = new List<int>();
        var i = 0;
        foreach (var item in times)
        {
            if (item == null) nulled.Add(i);
            i++;
        }

        return nulled;
    }
}