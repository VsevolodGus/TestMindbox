using BenchmarkDotNet.Attributes;
using TestMindBox.linq;

namespace Benchmark;

//[RankColumn]
[MemoryDiagnoser]
public class MyLinqBenchmark
{
    private readonly int takeLast = 4;
    private readonly int[] values = new int[] { 1, 2, 3, 4, 5 };

    [Benchmark(Description = "TakeLast через Func")]
    public void GetLastFunc()
    {
        values.TakeLast(takeLast);
    }


    [Benchmark(Description = "TakeLast через Queue")]
    public void GetLastQueue()
    { 
        values.GetLast(takeLast);
    }


    [Benchmark(Description = "Take через Func")]
    public void GetFirstFunc()
    {
        values.Take(takeLast);
    }


    [Benchmark(Description = "Take через Queue")]
    public void GetFirstQueue()
    {
        values.MyTake(takeLast);
    }


    [Benchmark(Description = "Skip через Func")]
    public void GetSkipFunc()
    {
        values.Skip(takeLast);
    }


    [Benchmark(Description = "Skip через Queue")]
    public void GetSkipQueue()
    {
        values.MySkip(takeLast);
    }

    [Benchmark(Description = "SkipLast через Func")]
    public void GetSkipLastFunc()
    {
        values.SkipLast(takeLast);
    }


    [Benchmark(Description = "SkipLast через Queue")]
    public void GetSkipLastQueue()
    {
        values.MySkipLast(takeLast);
    }




}
