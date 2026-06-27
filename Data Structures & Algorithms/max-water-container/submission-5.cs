public class Solution 
{
    public int MaxArea(int[] heights) 
    {
        int left = 0, right = heights.Length - 1, currWater = 0, maxWater = 0;

        while(left < right)    
        {
            currWater = (right - left) * (Math.Min(heights[left], heights[right]));
            maxWater = Math.Max(maxWater, currWater);

            if(heights[right] > heights[left]) left++;
            else right--;
        }


        return maxWater;
    }
}
