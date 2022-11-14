namespace TestMindBox.linq;

public static class TakeLast
{
    public static IEnumerable<T> TakeLastHelpers<T>(this IEnumerable<T> source, int takeLast)
                                 => GetByFuncIndex(source, x => x > source.Count() - takeLast);
    

    public static IEnumerable<T> SkipLastHelpers<T>(this IEnumerable<T> source, int skipLast)
                    => source.GetByFuncIndex(x => x > (source.Count() - skipLast));
    

    public static IEnumerable<T> TakeHelpers<T>(this IEnumerable<T> source, int take)
                    => source.GetByFuncIndex(x => x <= take);
    

    public static IEnumerable<T> SkipHelpers<T>(this IEnumerable<T> source, int skip)
                    => source.GetByFuncIndex(x => x > skip);

    private static IEnumerable<T> GetByFuncIndex<T>(this IEnumerable<T> source, Func<int, bool> func)
    {
        var e = source.GetEnumerator();
        int i = 0;
        while (e.MoveNext())
        {
            i++;
            if (func.Invoke(i))
                yield return e.Current;
        }
    }


    public static IEnumerable<T> GetLast<T>(this IEnumerable<T> source, int takeLast)
    {
        var e = source.GetEnumerator();
        if (!e.MoveNext())
            yield break;

        int count = 1;
        var quque = new Queue<T>(takeLast);
        quque.Enqueue(e.Current);

        while (e.MoveNext())
        {
            if (count < takeLast)
                count++;
            else
                quque.Dequeue();

            quque.Enqueue(e.Current);
        }


        for (int i = 0; i < takeLast; i++)
            yield return quque.Dequeue();
    }

}
