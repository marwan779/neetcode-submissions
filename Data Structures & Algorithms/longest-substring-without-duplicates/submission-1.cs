public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int l = 0, res = 0;
        HashSet<char> map = new HashSet<char>();

        for (int r = 0; r < s.Length; r++)
        {
            while (map.Contains(s[r]))
            {
                map.Remove(s[l]);
                l++;
            }
            
            map.Add(s[r]);
            res = Math.Max(res, r - l + 1);

        }

        return res;

    }
}