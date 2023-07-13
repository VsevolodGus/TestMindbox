namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/asteroid-collision/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class AsteroidCollisionTask
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        #region Мое решение
        var result = new List<int>();
        var stack = new Stack<int>();

        for (var i = 0; i < asteroids.Length; i++)
        {
            var asteroid = asteroids[i];
            if (!stack.Any() && asteroid < 0)
                result.Add(asteroid);
            else if (asteroid < 0)
            {
                while (asteroid != 0 && stack.TryPop(out int lastAsteroid))
                {
                    if (Math.Abs(asteroid) < lastAsteroid)
                    {
                        stack.Push(lastAsteroid);
                        asteroid = 0;
                    }
                    else if (Math.Abs(asteroid) == lastAsteroid)
                        asteroid = 0;

                }

                if (Math.Abs(asteroid) > 0)
                    result.Add(asteroid);
            }
            else
                stack.Push(asteroid);
        }

        result.AddRange(stack.Reverse());

        return result.ToArray();
        #endregion
    }
}
