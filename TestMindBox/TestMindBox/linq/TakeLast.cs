using System.Collections;

namespace TestMindBox.linq;

public static class TakeLast
{
    public static IEnumerable<T> TakeLastHelpers<T>(this IEnumerable<T> source, int takeLast)
                                 => GetByFuncIndex(source, x => x > source.Count() - takeLast);
    

    public static IEnumerable<T> SkipLastHelpers<T>(this IEnumerable<T> source, int skipLast)
                    => source.GetByFuncIndex(x => x <= (source.Count() - skipLast));
    

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

    public static IEnumerable<T> MyTake<T>(this IEnumerable<T> source, int take)
    {
        var e = source.GetEnumerator();

        if (!e.MoveNext())
            yield break;

        var quqeue = new Queue<T>();
        quqeue.Enqueue(e.Current);
        int count = 0;
        while (e.MoveNext() && count <= take)
        {
            quqeue.Enqueue(e.Current);
            count++;
        }

        for (int i = 0; i < take; i++)
            yield return quqeue.Dequeue();
    }

    public static IEnumerable<T> MySkip<T>(this IEnumerable<T> source, int skip)
    {
        var e = source.GetEnumerator();

        if (!e.MoveNext())
            yield break;

        var quqeue = new Queue<T>();
        int count = 1;
        while (e.MoveNext())
        {
            if (count++ >= skip)
                quqeue.Enqueue(e.Current);
        }

        for (int i = 0; i < count-skip; i++)
            yield return quqeue.Dequeue();
    }


    public static IEnumerable<T> MySkipLast<T>(this IEnumerable<T> source, int skipLast)
    {
        var e = source.GetEnumerator();

        if (!e.MoveNext())
            yield break;

        var quqeue = new Queue<T>();
        quqeue.Enqueue(e.Current);

        int count = 1;
        while (e.MoveNext())
        {
            quqeue.Enqueue(e.Current);
            count++;
        }
        
        for (int i = 0; i < count - skipLast; i++)
            yield return quqeue.Dequeue();
    }
}
