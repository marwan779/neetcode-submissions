  public class Solution
  {
      public bool IsPalindrome(string s)
      {
          if (String.IsNullOrEmpty(s)) return true;
          if (s.Length == 1) return true;

          

          char[] arr  = s.ToLower().Where(c => char.IsLetterOrDigit(c)).ToArray();

          int left = 0, right = arr.Length - 1;

          while (left <= right)
          {
              
              if (arr[left] != arr[right]) return false;

              left++;
              right--;
              
          }
              return true;
      }
  }