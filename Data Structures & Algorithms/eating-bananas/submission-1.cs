  public class Solution
  {
      public int MinEatingSpeed(int[] piles, int h)
      {
          int left = 1, righ = piles.Max(), hours = 0;
          int res = righ;
          int k = 1;

          //[1,4,3,2], h = 9
          //[1,2,3,4]
          while (left <= righ)
          {
              k = (left + righ) / 2;
              hours = 0;

              for (int i = 0; i < piles.Length; i++)
              {
                  hours += (int)Math.Ceiling((double)piles[i] / k);
              }

              if(hours <= h)
              {
                  righ = k - 1;
                  res = Math.Min(res, k);
              }
              else
              {
                  left = k + 1;
              }
          }

          return res;
      }
  }