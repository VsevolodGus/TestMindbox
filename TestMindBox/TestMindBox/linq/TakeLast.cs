namespace TestMindBox.linq;

public static class TakeLast
{
    public static IEnumerable<T> TakeLastHelpers<T>(this IEnumerable<T> source, int takeLast)
    {
        var sourceEnumerator = source.GetEnumerator();

        int i = 0;
        while (sourceEnumerator.MoveNext())
        {
            i++;
            if (i > source.Count() - takeLast)
                yield return sourceEnumerator.Current;
        }
    }

    public static IEnumerable<T> TakeHelpers<T>(this IEnumerable<T> source, int take)
    {
        var sourceEnumerator = source.GetEnumerator();
        
        int i = 0;
        while (sourceEnumerator.MoveNext())
        {
            i++;
            if (i <= take)
                yield return sourceEnumerator.Current;
            else
                yield break;
        }
    }

    public static IEnumerable<T> SkipHelpers<T>(this IEnumerable<T> source, int skip)
    {
        var sourceEnumerator = source.GetEnumerator();

        int i = 0;
        while (sourceEnumerator.MoveNext())
        {
            i++;
            if (i > skip)
                yield return sourceEnumerator.Current;
        }
    }


    public static IEnumerable<T> SkipLastHelpers<T>(this IEnumerable<T> source, int skipLast)
    {
        var sourceEnumerator = source.GetEnumerator();

        int i = 0;
        while (sourceEnumerator.MoveNext())
        {
            i++;
            if (i > source.Count() - skipLast)
                yield return sourceEnumerator.Current;
        }
    }
}
