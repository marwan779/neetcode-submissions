public class Solution {
    public int FindMin(int[] nums) 
    {
        int left = 0, right = nums.Length - 1, result = nums[left];

        if(nums[right] > nums[left]) // sorted array
        {
            result = nums[left];
            return result;
        }

        while(left <= right)
        {
            int mid = (left + right) / 2;
            result = Math.Min(result, nums[mid]);

            if(nums[mid] > nums[right]) left = mid + 1;
            else right = mid - 1;
        }


        return result;    
    }
}
