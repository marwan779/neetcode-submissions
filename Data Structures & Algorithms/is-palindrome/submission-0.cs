public class Solution
{
	public bool IsPalindrome(string s)
	{
		if(String.IsNullOrEmpty(s)) return true;
		if(s.Length == 1) return true;

		

		char[] CharArray = s.ToLower().Where(c => char.IsLetterOrDigit(c)).ToArray();
		int Left = 0, Right = CharArray.Length - 1;

		while(Left < Right)
		{
			if (CharArray[Left] != CharArray[Right])
			{
				return false;
			}
			Left++;
			Right--;
		}

		return true;
	}
}