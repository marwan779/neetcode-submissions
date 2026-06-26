 public class Solution
 {
     public int[] ProductExceptSelf(int[] nums)
     {
         int temp = 1;
         int[] Arr = new int[nums.Length];

         for (int i = 0; i < nums.Length; i++)
         {
             for (int j = 0; j < nums.Length; j++)
             {
                 if (j == i) continue;
                 else
                 {
                     temp *= nums[j];
                 }
             }

             Arr[i] = temp;

             temp = 1;
         }

         return Arr;
     }
 }