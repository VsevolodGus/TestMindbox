using System.Text;

namespace TestMindBox.SBC;
internal class FlowersData
{
    public char[] Flowers;

    public FlowersData(int countFlowers)
    {
        Flowers = new char[countFlowers];
        Flowers[0] = 'A';
        for (int i = 1; i < Flowers.Length; i++)
            Flowers[i] = (char)(Flowers[i - 1] + 1);
    }

    /// <summary>
    /// Вычисление дистанции между городами
    /// </summary>
    /// <param name="firstCity"></param>
    /// <param name="secondCity"></param>
    /// <returns>расстояние</returns>
    public double Distance(char firstCity, char secondCity)
        => firstCity < secondCity 
            ? 1.0 * (secondCity - firstCity) 
            : 1.5 * (firstCity - secondCity);

    public double ShortestPathLength()
        => 1.0 * (Flowers.Length - 1);
    

    public long NumberOfPossiblePaths()
    {
        long answer = 1;
        for (int i = 1; i <= Flowers.Length; ++i)
            checked { answer *= i; }

        return answer;
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder("Cities: ");

        foreach(var city in Flowers)
            stringBuilder.Append(city + " ");

        return stringBuilder.ToString();
    }
}
