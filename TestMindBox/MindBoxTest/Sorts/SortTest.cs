using TestMindBox.Sorts;

namespace MindBoxTest.Sorts;

public class SortTest
{
    private readonly int[] _source = new int[] { 1, 4, 5, 3, 7, 8, 6, 9, 2, 0 };

    private readonly IReadOnlyCollection<int> _resultAsc = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    private readonly IReadOnlyCollection<int> _resultDesc = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

    [Fact]
    private void SortByDesc()
    {
        var result = _source.Sorting(false);

        Assert.Equal(_resultDesc, result);
    }

    [Fact]
    private void SortByAsc()
    {
        var result = _source.Sorting(true);

        Assert.Equal(_resultAsc, result);
    }
}
