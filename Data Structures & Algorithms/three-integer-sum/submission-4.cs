public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        var result = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] > 0) break;

             if (i > 0 && nums[i] == nums[i - 1])
                continue;

            var pairs = TwoSums(nums, i + 1, -nums[i]);

            foreach (var p in pairs)
            {
                result.Add(new List<int> { nums[i], p[0], p[1] });
            }
        }

        return result;
    }

    public List<List<int>> TwoSums(int[] nums, int start, int target)
    {
        int left = start, right = nums.Length - 1;
        var result = new List<List<int>>();

        while (left < right)
        {
            int sum = nums[left] + nums[right];

            if (sum < target) left++;
            else if (sum > target) right--;
            else
            {
                
                result.Add(new List<int> {nums[left], nums[right]});
                left++;
                right--;
                while(left < right && nums[left] == nums[left - 1]) left++;
                while(left < right && nums[right] == nums[right + 1]) right--;
            }
        }


        return result;
    }

}