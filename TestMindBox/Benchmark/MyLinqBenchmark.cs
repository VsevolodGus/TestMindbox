using BenchmarkDotNet.Attributes;

namespace Benchmark;

//[RankColumn]
[MemoryDiagnoser]
public class MyLinqBenchmark
{
    public static readonly int y = 42;
    public static readonly int y1 = 42;
    private readonly object[] asd = new object[1000000000];

    [Benchmark(Description = "Сравнение ==")]
    public void ForEachWithOperatorEqeuals()
    {
        int count = 1;
        foreach (var obj in asd)
        {
            if (obj == null)
            {
                count++;
            }
        }
    }


    [Benchmark(Description = "Сравнение is")]
    public void ForEachWithIs()
    {
        int count = 1;
        foreach (var obj in asd)
        {
            if (obj is null)
            { 
                count++;
            }
        }
    }


    [Benchmark(Description = "Сравнение !=")]
    public void ForEachWithOperatorNotEqueals()
    {
        int count = 1;
        foreach (var obj in asd)
        {
            if (obj != null)
            { 
                count++;
            }
        }
    }


    [Benchmark(Description = "Сравнение is not")]
    public void ForEachWithIsNotNull()
    {
        int count = 1;
        foreach (var obj in asd)
        {
            if (obj is not null)
            { 
                count++;
            }
        }
    }

    //private readonly int takeLast = 4;
    //private readonly int[] values = new int[] { 1, 2, 3, 4, 5 };

    //[Benchmark(Description = "TakeLast через Func")]
    //public void GetLastFunc()
    //{
    //    values.TakeLast(takeLast);
    //}


    //[Benchmark(Description = "TakeLast через Queue")]
    //public void GetLastQueue()
    //{ 
    //    values.GetLast(takeLast);
    //}


    //[Benchmark(Description = "Take через Func")]
    //public void GetFirstFunc()
    //{
    //    values.Take(takeLast);
    //}


    //[Benchmark(Description = "Take через Queue")]
    //public void GetFirstQueue()
    //{
    //    values.MyTake(takeLast);
    //}


    //[Benchmark(Description = "Skip через Func")]
    //public void GetSkipFunc()
    //{
    //    values.Skip(takeLast);
    //}


    //[Benchmark(Description = "Skip через Queue")]
    //public void GetSkipQueue()
    //{
    //    values.MySkip(takeLast);
    //}

    //[Benchmark(Description = "SkipLast через Func")]
    //public void GetSkipLastFunc()
    //{
    //    values.SkipLast(takeLast);
    //}


    //[Benchmark(Description = "SkipLast через Queue")]
    //public void GetSkipLastQueue()
    //{
    //    values.MySkipLast(takeLast);
    //}




}
