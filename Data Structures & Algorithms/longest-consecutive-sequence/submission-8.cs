public class Solution 
{
   public int LongestConsecutive(int[] nums) 
    {

        if(nums.Length == 1) return 1;

        var set = new HashSet<int>(nums);
        int longest = 0;


        foreach(int num in set)
        {

            if(!set.Contains(num  - 1))
            {
                int currNum = num;
                int currSeq = 1;

                while(set.Contains(currNum + 1))
                {
                    currNum++;
                    currSeq++;

                }

                    longest = Math.Max(longest, currSeq);

            }
        }

        return longest;

    }
}
