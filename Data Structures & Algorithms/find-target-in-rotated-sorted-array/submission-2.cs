public class Solution {
    public int Search(int[] nums, int target) 
    {
        int left = 0, right = nums.Length - 1;

        while(left <= right)
        {
            int mid = (left + right) / 2;

            if(nums[mid] == target)
                return mid;

            if(nums[left] <= nums[mid])
            {
                // left side is sorted
                if(target >= nums[left] && target < nums[mid])
                {
                    //search left
                    right = mid - 1;
                }
                else
                {
                    // search right
                    left = mid + 1;
                }
            }
            else
            {
                if(target > nums[mid] && target <= nums[right])
                {
                    // search right
                    left = mid + 1;
                }
                else
                {
                    //search left
                    right = mid - 1;
                }
            }
        }

        return -1;    
    }
}
