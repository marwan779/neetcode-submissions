public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        int[] freqS = new int[26];
        int[] freqT = new int[26];

        // Count frequencies
        for (int i = 0; i < s.Length; i++) {
            freqS[s[i] - 'a']++;
            freqT[t[i] - 'a']++;
        }

        for(int i = 0; i < 26; i++)
        {
            if(freqS[i] != freqT[i]) return false;
        }

        return true;
    }
}
