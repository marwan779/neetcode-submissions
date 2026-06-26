public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> result = new List<List<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
                break;

            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            var pairs = TwoSum(nums, i + 1, -nums[i]);

            foreach (var p in pairs)
            {
                result.Add(new List<int> { nums[i], p[0], p[1] });
            }

        }

        return result;
    }

    private List<List<int>> TwoSum(int[] nums, int start, int target)
    {
        int end = nums.Length - 1, sum = 0;
        List<List<int>> res = new List<List<int>>();

        while (start < end)
        {
            sum = nums[start] + nums[end];
            if (sum == target)
            {
                res.Add(new List<int> { nums[start], nums[end] });

                start++;
                end--;

                while(start < end && nums[start] == nums[start - 1]) start++;
                while(start < end && nums[end] == nums[end + 1]) end--;
            }
            else if (sum < target)
            {
                start++;
            }
            else
            {
                end--;
            }

        }

        return res;
    }
}