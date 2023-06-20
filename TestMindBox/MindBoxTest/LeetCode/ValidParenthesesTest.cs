using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class ValidParenthesesTest
{
    private readonly ValidParentheses worker = new();
    
    [Fact]
    public void HasCloseParentheses()
    {
        const string s = "()()";
        var result = worker.IsValid(s);
        Assert.True(result);
    }

    [Fact]
    public void HasNoCloseParentheses()
    {
        const string s = "()(";
        var result = worker.IsValid(s);
        Assert.False(result);
    }
    [Fact]
    public void HasCloseSquareBrackets()
    {
        const string s = "[[]]";
        var result = worker.IsValid(s);
        Assert.True(result);
    }

    [Fact]
    public void HasNoCloseSquareBrackets()
    {
        const string s = "[]]";
        var result = worker.IsValid(s);
        Assert.False(result);
    }

    [Fact]
    public void HasNoCloseCurlyBrackets()
    {
        const string s = "{{}";
        var result = worker.IsValid(s);
        Assert.False(result);
    }

    [Fact]
    public void HasCloseCurlyBrackets()
    {
        const string s = "{}{}";
        var result = worker.IsValid(s);
        Assert.True(result);
    }

    [Fact]
    public void HasCloseAllBrackets()
    {
        const string s = "{}()[]";
        var result = worker.IsValid(s);
        Assert.True(result);
    }
    
    [Fact]
    public void HasCloseInsideAllBrackets()
    {
        const string s = "{([])}";
        var result = worker.IsValid(s);
        Assert.True(result);
    }

    [Fact]
    public void HasCloseDifferentBrackets()
    {
        const string s = "(}";
        var result = worker.IsValid(s);
        Assert.False(result);
    }

    [Fact]
    public void HasNoCloseBrackets()
    {
        const string s = ")(";
        var result = worker.IsValid(s);
        Assert.False(result);
    }

    [Fact]
    public void DoubleBrackets()
    {
        const string s = "([}}])";
        var result = worker.IsValid(s);
        Assert.False(result);
    }

    [Fact]
    public void DoubleBrackets_Second()
    {
        const string s = "))";
        var result = worker.IsValid(s);
        Assert.False(result);
    }
}
