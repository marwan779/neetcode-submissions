 public class Solution
 {
     public int MaxArea(int[] heights)
     {
         int maxArea = 0, currentArea = 0, left = 0, right = heights.Length - 1;

         while (left < right)
         {
             int width = right - left;
             int height = Math.Min(heights[left], heights[right]);

             currentArea = height * width;

             maxArea = Math.Max(maxArea, currentArea);

             if (heights[left] < heights[right]) left++;
             else right--;
         }

         return maxArea;
     }
 }