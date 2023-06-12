namespace TestMindBox.Codewars;
internal class CalculateVelueOfTwoArrays
{
    public static double Solution(int[] firstArray, int[] secondArray)
    {
        var result = 0.0;
        for(int i = 0; i< firstArray.Length; i++)  
            result += Math.Pow(firstArray[i] - secondArray[i], 2);

        return result / firstArray.Length;
    }
}
