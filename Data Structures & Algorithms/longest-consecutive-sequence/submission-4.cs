public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;

        Array.Sort(nums);
        int longest = 1;
        int currentStreak = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1]) continue; // Skip duplicates
            if (nums[i] == nums[i - 1] + 1)
            {
                currentStreak++;
            }
            else
            {
                longest = Math.Max(longest, currentStreak);
                currentStreak = 1;
            }
        }

        return Math.Max(longest, currentStreak);
    }
}
