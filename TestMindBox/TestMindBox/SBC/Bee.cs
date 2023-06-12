using System.Text;

namespace TestMindBox.SBC;
internal class Bee
{
    public StatusBee Status;
    public char[] MemoryMatrix;
    public double MeasureOfQuality;
    public int CountrOfVisits;

    public Bee(StatusBee status
        , char[] memoryMatrix
        , double measureOfQuality
        , int numberOfVisits)
    {
        Status = status;

        MemoryMatrix = new char[memoryMatrix.Length];
        Array.Copy(memoryMatrix, MemoryMatrix, MemoryMatrix.Length);

        MeasureOfQuality = measureOfQuality;
        CountrOfVisits = numberOfVisits;
    }

    /// <summary>
    /// Переопределил для вывода данных о пчеле
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.AppendLine("Status = " + Status);
        stringBuilder.AppendLine("Status = " + Status);
        stringBuilder.AppendLine(" Memory = ");

        for (int i = 0; i < MemoryMatrix.Length - 1; ++i)
            stringBuilder.Append( MemoryMatrix[i] + "->");
        stringBuilder.AppendLine(MemoryMatrix[MemoryMatrix.Length - 1].ToString());

        stringBuilder.AppendLine(" Quality = " + MeasureOfQuality.ToString("F4"));
        stringBuilder.AppendLine(" Number visits = " + CountrOfVisits);

        return stringBuilder.ToString();;
    }
}
