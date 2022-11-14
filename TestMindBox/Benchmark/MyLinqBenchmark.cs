using BenchmarkDotNet.Attributes;
using TestMindBox.linq;

namespace Benchmark;

[RankColumn]
[MemoryDiagnoser]
public class MyLinqBenchmark
{
    private readonly int takeLast = 4;
    private readonly int[] values = new int[] { 1, 2, 3, 4, 5 };

[Benchmark(Description = "TakeLast через Func")]
    public void GetLastFunc()
    {
        values.TakeLastHelpers(takeLast);
    }


    [Benchmark(Description = "TakeLast через Queue")]
    public void GetLastQueue()
    { 
        values.GetLast(takeLast);
    }

    
}
