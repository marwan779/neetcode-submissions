public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int l_m = 1, r_m = 1, temp = nums.Length - 1;
        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];
        int[] result = new int[nums.Length];

        left[0] = l_m;
        right[temp] = r_m;
        temp--;
        for (int i = 1; i < nums.Length; i++)
        {
            left[i] = nums[i - 1] * l_m;
            l_m = left[i];

            right[temp] = nums[temp + 1] * r_m;
            r_m = right[temp];
            temp--;
        }

        for (int i = 0; i < nums.Length; i++)
        {
           result[i] = left[i] * right[i];
        }

       return result;

    }
}