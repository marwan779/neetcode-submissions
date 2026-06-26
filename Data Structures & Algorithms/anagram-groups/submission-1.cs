  public class Solution
  {
      public List<List<string>> GroupAnagrams(string[] strs)
      {
          Dictionary<string, List<string>> Result = new Dictionary<string, List<string>>();

          foreach (string str in strs)
          {
              char[] chars = str.ToCharArray();

              Array.Sort(chars);

              string Sorted  = new string(chars);

              if (!Result.ContainsKey(Sorted))
              {
                  Result[Sorted] = new List<string>();
              }

              Result[Sorted].Add(str);
          }

         
          return Result.Values.ToList();
      }
  }