 public class Solution
 {
     public int LongestConsecutive(int[] nums)
     {
         int CurrentChain = 1, LongestChain = 1;

         if(nums.Length == 0 )  return 0;

         nums = nums.OrderBy(x => x).ToArray();

         for (int i = 1; i < nums.Length; i++)
         {
             if (nums[i] == nums[i - 1]) continue;
             if (nums[i] == nums[i - 1] + 1) CurrentChain++;
             else
             {
                 LongestChain = Math.Max(CurrentChain, LongestChain);
                 CurrentChain = 1;
             }
         }

         return Math.Max(CurrentChain, LongestChain);
     }
 }

