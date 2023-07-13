using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class AsteroidCollisionTaskTest
{
    private readonly AsteroidCollisionTask _worker = new();

    [Fact]
    public void FirstTest()
    {
        var asteroids = new int[] { 5, 10, -5 };

        var result = _worker.AsteroidCollision(asteroids);

        Assert.Equal(new int[] { 5, 10 }, result);
    }

    [Theory]
    [InlineData(new int[] { 8, -8})]
    [InlineData(new int[] { 1, -1, 1, -1})]
    [InlineData(new int[] { 2, -2})]
    public void ResultEmpty(int[] asteroids)
    {
        var result = _worker.AsteroidCollision(asteroids);

        Assert.Equal(Array.Empty<int>(), result);
    }

    [Theory]
    [InlineData(new int[] { 8, -2 }, new int[] { 8 })]
    [InlineData(new int[] { 3, -1 }, new int[] { 3 })]
    [InlineData(new int[] { 3, -1, -1 }, new int[] { 3 })]
    public void SimpleOnlyRiht(int[] asteroids, int[] exceptedResult)
    {
        var result = _worker.AsteroidCollision(asteroids);

        Assert.Equal(exceptedResult, result);
    }

    [Theory]
    [InlineData(new int[] { 2, -8 }, new int[] { -8})]
    [InlineData(new int[] { 1, -3 }, new int[] { -3 })]
    [InlineData(new int[] { 1, 1, -3 }, new int[] { -3 })]
    public void SimpleOnlyWithLeft(int[] asteroids, int[] exceptedResult)
    {
        var result = _worker.AsteroidCollision(asteroids);

        Assert.Equal(exceptedResult, result);
    }
}
