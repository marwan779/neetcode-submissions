public class Solution
{
	public int GenerateAnagramHash(string Input)
	{
		int[] Hash = new int[26];
		int Result = 0;

		foreach(char c in Input)
		{
			Hash[c - 'a'] ++;
		}

		foreach(int i  in Hash)
		{
			Result = Result * 31 + i; 
		}

		return Result;
	}
	public bool IsAnagram(string s, string t)
	{
		
		if (s.Length == 0 || t.Length == 0 || (s.Length != t.Length)) return false;

		return GenerateAnagramHash(s) == GenerateAnagramHash(t);
	}
}