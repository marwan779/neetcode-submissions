public class Solution
{
	public bool IsValidSudoku(char[][] board)
	{
		Dictionary<int, List<char>> Row = new Dictionary<int, List<char>>();
		Dictionary<int, List<char>> Col = new Dictionary<int, List<char>>();
		Dictionary<int, List<char>> Box = new Dictionary<int, List<char>>();
		char Digit;
		int BoxIndex = 0;

		for (int i = 0; i < 9; i++)
		{
			Row.Add(i, new List<char>());
			Col.Add(i, new List<char>());
			Box.Add(i, new List<char>());
		}

		for(int i = 0; i < 9; i++)
		{
			for(int j = 0; j < 9; j++)
			{
				Digit = board[i][j];
				if(Digit == '.') continue;

				if (Row[i].Contains(Digit)) return false;
				Row[i].Add(Digit);

				if (Col[j].Contains(Digit)) return false;
				Col[j].Add(Digit);

				BoxIndex = (i / 3) * 3 + j/3;

				if (Box[BoxIndex].Contains(Digit)) return false;
				Box[BoxIndex].Add(Digit);
			}
		}

		return true;
	}
}