public class Solution
{
	public int[] ProductExceptSelf(int[] nums)
	{
		if (nums.Length == 0) return new int[] { };
		int[] Result = new int[nums.Length];
		int Initial = 1;

		for(int i = 0; i< nums.Length; i++)
		{
			Result[i] = Initial;
			Initial *= nums[i];
		}

		Initial = 1;

		for(int j = nums.Length-1; j >= 0; j--)
		{
			Result[j] = Result[j] * Initial;
			Initial *= nums[j];
		}

		return Result;
	}
}