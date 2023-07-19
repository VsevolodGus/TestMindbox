//using TestMindBox.LeetCode;

//namespace MindBoxTest.LeetCode;
//public class StringCompressionTest
//{
//    private readonly StringCompression _worker = new();

//    [Theory]
//    [InlineData(new char[] { 'a' }, 1, new char[] { 'a' })]
//    [InlineData(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }, 6, new char[] { 'a','2','b','2','c','3' })]
//    [InlineData(new char[] { "a", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b" }
//                            , 6
//                            , new char[] { 'a','2','b','2','c','3' })]
//    public void Test(char[] chars, int exceptedResult, char[] exceptedCharsAfter)
//    {
//        var result = _worker.Compress(chars);

//        Assert.Equal(exceptedResult, result);
//        Assert.Equal(exceptedCharsAfter, chars);
//    }
//}
