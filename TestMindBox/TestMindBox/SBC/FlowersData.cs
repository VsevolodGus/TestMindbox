using System.Text;

namespace TestMindBox.SBC;
internal class FlowersData
{
    public char[] cities;

    public FlowersData(int numberCities)
    {
        this.cities = new char[numberCities];
        this.cities[0] = 'A';
        for (int i = 1; i < this.cities.Length; i++)
            this.cities[i] = (char)(this.cities[i - 1] + 1);
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
        => 1.0 * (this.cities.Length - 1);
    

    public long NumberOfPossiblePaths()
    {
        long answer = 1;
        for (int i = 1; i <= this.cities.Length; ++i)
            checked { answer *= i; }

        return answer;
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder("Cities: ");

        foreach(var city in this.cities)
            stringBuilder.Append(city + " ");

        return stringBuilder.ToString();
    }
}
