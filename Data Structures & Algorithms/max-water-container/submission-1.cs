 public class Solution
 {
     public int MaxArea(int[] heights)
     {
         //Brute-Force Solution

         int maxArea = 0, currentArea = 0;

         for (int i = 0; i < heights.Length; i++)
         {
             for (int j = i + 1; j < heights.Length; j++)
             {
                 currentArea = Math.Min(heights[i], heights[j]) * (j - i);
                 maxArea = Math.Max(maxArea, currentArea);
             }
         }

         return maxArea;
     }
 }
