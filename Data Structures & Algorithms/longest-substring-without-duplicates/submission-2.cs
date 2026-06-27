public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int left = 0, right = 0, maxLenght = 0;
        HashSet<char> chars = new HashSet<char>();

        while (right < s.Length)
        {
            while (chars.Contains(s[right]))
            {
                chars.Remove(s[left]);
                left++;
            }

            chars.Add(s[right]);
            maxLenght = Math.Max((right - left + 1), maxLenght);
            right++;

        }
        return maxLenght;
    }

}