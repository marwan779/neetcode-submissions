  public class Solution
  {
      public bool IsPalindrome(string s)
      {
          if (String.IsNullOrEmpty(s)) return true;
          if (s.Length == 1) return true;
          string news = "";
          foreach(char c in s)
            {
                if(char.IsLetterOrDigit(c))
                {
                    news+= char.ToLower(c);
                }
            }
          return news == new string(news.Reverse().ToArray());
      }
  }