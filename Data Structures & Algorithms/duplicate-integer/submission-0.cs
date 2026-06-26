public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        Dictionary<int, int> HashTable = new Dictionary<int, int>();

        if (nums.Length == 0) return false;

        for (int i = 0; i < nums.Length; i++)
        {
            if (HashTable.ContainsKey(nums[i])) return true;

            HashTable[nums[i]] = i;
        }

        return false;
    }
}