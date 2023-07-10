namespace TestMindBox.LeetCode;
public class UniqueNumberOccurrences
{
    public bool UniqueOccurrences(int[] arr)
    {
        #region My solution
        //var result = new Dictionary<int, int>();

        //foreach (int i in arr) 
        //{ 
        //    if(result.ContainsKey(i))
        //        result[i]++;
        //    else
        //        result.Add(i, 0);
        //}

        //return new HashSet<int>(result.Values).Count == result.Count;
        #endregion

        Array.Sort(arr);
        var list = new List<int>();

        for(int i = 0; i < arr.Length;) 
        {
            var countValue = Array.FindAll(arr, c=> c == arr[i]).Length;
            if(list.Contains(countValue))
                return false;
            else 
                list.Add(countValue);

            i += countValue;
        }

        return true;
    }

}
