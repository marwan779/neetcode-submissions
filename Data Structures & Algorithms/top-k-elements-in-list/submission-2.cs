public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            }
            else
            {
                map.Add(nums[i], 1);
            }
        }

        // Sort by frequency descending, take top k KEYS
        int[] result = map
            .OrderByDescending(kvp => kvp.Value)
            .Take(k)
            .Select(kvp => kvp.Key)
            .ToArray();

        return result; 
    }
}
