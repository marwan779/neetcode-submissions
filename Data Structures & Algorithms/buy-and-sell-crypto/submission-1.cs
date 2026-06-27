public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int left = 0, right = 1, maxAmount = 0;

        while(right < prices.Length)
        {
            int currAmount = prices[right] - prices[left];

            if(prices[right] < prices[left])
            {
                left = right;
            }

            right++;

            maxAmount = Math.Max(maxAmount, currAmount);
        }


        return maxAmount;        
    }
}
