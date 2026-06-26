 public class Solution
 {
     public int MaxArea(int[] heights)
     {
         if(heights.Length == 0) return 0;

         int maxArea = 0, currentMaxArea = 0;

         for (int i = 0; i < heights.Length; i++)
         {

             for(int j = i + 1;j < heights.Length; j++)
             {
                 currentMaxArea = Math.Min(heights[i], heights[j]) * (j -i);
                 maxArea = Math.Max(maxArea, currentMaxArea);

             }
         }

         return maxArea;
     }
 }