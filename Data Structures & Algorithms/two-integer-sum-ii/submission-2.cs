public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0, right = numbers.Length - 1;
        int sum = 0;
        while (left < right)
        {
            sum = numbers[left] + numbers[right];

            if (sum < target)
            {
                left++;
                continue;
            }

            else if (sum > target)
            {
                right--;
                continue;
            }
            else 
            {
                return new int[] { left + 1, right + 1 };
            }

        }
        return new int[] { left + 1, right + 1 };
    }
}