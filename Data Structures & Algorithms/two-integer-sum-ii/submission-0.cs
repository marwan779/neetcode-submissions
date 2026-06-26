public class Solution 
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int Left = 0, Right = numbers.Length - 1;

        while (Left < Right)
        {
            if (numbers[Left] + numbers[Right] < target) Left++;
            else if (numbers[Left] + numbers[Right] > target) Right--;
            else return new int[] {Left+1, Right+1};
        }
        return new int[] { Left + 1, Right + 1 };
    }
}