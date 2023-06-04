using System.Reflection;
using TestMindBox.linq;

namespace TestMindBox;

public static class TestYarikLinq
{

    public static IEnumerable<T> CustomTake<T>(this IEnumerable<T> source, int take)
    {
        int index = 0;
        foreach(T t in source)
        {
            if (index == take)
                break;
            index++;

            yield return t;
        }

        var Node = new Node()
        {
            ID = 1,
        };
    }
}

