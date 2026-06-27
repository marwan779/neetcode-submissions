public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int left = 0, right = 0, mostFreq = 0, maxLength = 0;
        var map = new Dictionary<char, int>();

        while(right < s.Length)
        {
            if(map.ContainsKey(s[right]))
            {
                map[s[right]]++;
            }
            else
            {
                map.Add(s[right], 1);
            }


            mostFreq = Math.Max(map[s[right]], mostFreq);

            while((right - left + 1) - mostFreq > k)
            {
                map[s[left]]--;
                left++;
            }

            maxLength = Math.Max(maxLength, (right - left + 1));

            right++;
        }



        return maxLength; 
    }
}

