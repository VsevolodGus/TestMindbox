namespace TestMindBox.LeetCode;
public class ValidParentheses
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
             return false;

        var stack = new Stack<char>();
        var openBrackets = new char[] {'(','[','{' };
        for (int i = 0; i < s.Length; i++)
        {
            if (openBrackets.Contains(s[i]))
                stack.Push(s[i]);
            else if (stack.TryPeek(out char bracket))
            {
                if( (bracket == '(' && s[i] == ')')
                    || (bracket == '[' && s[i] == ']')
                    || (bracket == '{' && s[i] == '}'))
                    stack.Pop();
                else
                    return false;
            }
            else return false;
        }

        return !stack.Any();
    }
}
