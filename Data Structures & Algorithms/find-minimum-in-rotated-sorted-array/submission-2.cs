public class Solution 
{
    public int FindMin(int[] nums)
{
    if (nums[0] < nums[nums.Length - 1]) return nums[0];
    if(nums.Length == 1) return nums[0];

    int left = 0, right = 0;

    for (int i = 1; i < nums.Length; i++)
    {
        left = i - 1; right = i + 1;
        if(i == nums.Length - 1) return nums[i];
        if((nums[i] < nums[left] && nums[i] < nums[right])) return nums[i];
        
    }

    return -1;
}
}
