
public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int requiredNum = target - nums[i];

            if (map.ContainsKey(requiredNum))
                return new int[] { map[requiredNum], i };

            map[nums[i]] = i; // better than Add (avoids exception if duplicate)
        }

        return new int[] {};
    }
}