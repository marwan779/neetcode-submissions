public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

        foreach (int i in nums)
        {
            if (keyValuePairs.ContainsKey(i)) return true;

            keyValuePairs.Add(i, i);
        }

        return false;
    }
}