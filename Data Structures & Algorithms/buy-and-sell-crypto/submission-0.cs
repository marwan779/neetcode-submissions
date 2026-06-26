public class Solution
{

    //[10,1,5,6,7,1]
    public int MaxProfit(int[] prices)
    {
        int l = 0, r = 1, profit = 0;

        while (r < prices.Length)
        {
            int temp = prices[r] - prices[l];
            if (temp < 0)
            {
                l = r;
                r++;
            }
            else
            {
                if(temp > profit) 
                { 
                    profit = temp; 
                }

                r++;
            }
        }

        return profit;
    }
}