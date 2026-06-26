public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int maxWindowSize = 0, currWindowSize = 0, leftPointer = 0, mostFreq = 0;

        Dictionary<char, int> map = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {

            currWindowSize++;

            if (map.ContainsKey(s[i]))
            {
                map[s[i]]++;
            }
            else
            {
                map.Add(s[i], 1);
            }

            mostFreq = Math.Max(mostFreq, map[s[i]]);

            if (currWindowSize - mostFreq > k)
            {
                map[s[leftPointer]]--;
                leftPointer++;
                currWindowSize--;
            }


            maxWindowSize = Math.Max(maxWindowSize, currWindowSize);

        }


        return maxWindowSize;
    }
}

