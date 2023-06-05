using System.Text;

namespace TestMindBox.SBC;
internal class Bee
{
    public StatusBee status;
    public char[] memoryMatrix;
    public double measureOfQuality;
    public int numberOfVisits;

    public Bee(StatusBee status
        , char[] memoryMatrix
        , double measureOfQuality
        , int numberOfVisits)
    {
        this.status = status;

        this.memoryMatrix = new char[memoryMatrix.Length];
        Array.Copy(memoryMatrix, this.memoryMatrix, this.memoryMatrix.Length);

        this.measureOfQuality = measureOfQuality;
        this.numberOfVisits = numberOfVisits;
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.AppendLine("Status = " + this.status);
        stringBuilder.AppendLine("Status = " + this.status);
        stringBuilder.AppendLine(" Memory = ");

        for (int i = 0; i < this.memoryMatrix.Length - 1; ++i)
            stringBuilder.Append( this.memoryMatrix[i] + "->");
        stringBuilder.AppendLine(this.memoryMatrix[this.memoryMatrix.Length - 1].ToString());

        stringBuilder.AppendLine(" Quality = " + this.measureOfQuality.ToString("F4"));
        stringBuilder.AppendLine(" Number visits = " + this.numberOfVisits);

        return stringBuilder.ToString();;
    }
}
