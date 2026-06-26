  public class Solution
  {
      public bool IsValidSudoku(char[][] board)
      {
          for (int i = 0; i < 9; i++)
          {
              Dictionary<char, int> IsDuplicate = new Dictionary<char, int>();

              for (int j = 0; j < 9; j++)
              {
                  if (board[i][j] == '.') continue;
                  if (IsDuplicate.ContainsKey(board[i][j])) return false;
                  IsDuplicate[board[i][j]] = 1;
              }
          }

          for (int i = 0; i < 9; i++)
          {
              Dictionary<char, int> IsDuplicate = new Dictionary<char, int>();

              for (int j = 0; j < 9; j++)
              {
                  if (board[j][i] == '.') continue;
                  if (IsDuplicate.ContainsKey(board[j][i])) return false;
                  IsDuplicate[board[j][i]] = 1;
              }
          }

          for (int square = 0; square < 9; square++)
          {
              HashSet<char> seen = new HashSet<char>();
              for (int i = 0; i < 3; i++)
              {
                  for (int j = 0; j < 3; j++)
                  {
                      int row = (square / 3) * 3 + i;
                      int col = (square % 3) * 3 + j;
                      if (board[row][col] == '.') continue;
                      if (seen.Contains(board[row][col])) return false;
                      seen.Add(board[row][col]);
                  }
              }
          }

          return true;
      }
  }