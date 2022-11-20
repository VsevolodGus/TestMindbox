using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestMindBox.Sorts;

public static class Sort
{
    public static int[] Sorting(this int[]source, bool orderBy)
    {
        Func<int, int, bool> func = orderBy ? (value1, value2) => value1 > value2 
                                            : (value1, value2) => value1 < value2;

        for (int i = 0; i < source.Length; i++)
        for (int j = i; j < source.Length; j++)
            if (func(source[i],  source[j]))
                    Swap(ref source[i], ref source[j]);

        return source;
    }

    private static void Swap<T>(ref T value1, ref T value2)
    {
        var temp = value1;
        value1 = value2;
        value2 = temp;
    }

}
