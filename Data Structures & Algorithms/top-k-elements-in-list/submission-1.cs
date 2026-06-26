 public class Solution
 {
     public int[] TopKFrequent(int[] nums, int k)
     {

         Dictionary<int, int> Result = new Dictionary<int, int>();
         int[] ResultArr = new int[k];


         foreach (int x in nums)
         {
             if(!Result.ContainsKey(x))
             {
                 Result[x] = 1;
             }
             else
             {
                 Result[x] = Result[x] +1;
             }
         }


         int[] result = Result
                 .OrderByDescending(pair => pair.Value)
                 .Take(k)
                 .Select(pair => pair.Key)
                 .ToArray();

         return result;
     }
 }