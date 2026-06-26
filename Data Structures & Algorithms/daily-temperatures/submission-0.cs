 public class Solution
 {
     public int[] DailyTemperatures(int[] temperatures)
     {
         int left = 0, right = 1, temp = 0;
         int[] result = new int[temperatures.Length];

         for(int i = 0; i < temperatures.Length; i++)
         {
             left = i;
             right = left + 1;

             if (i == temperatures.Length - 1)
             {
                 result[i] = 0;
                 break;
             }

             if (temperatures[left] < temperatures[right])
             {
                 temp = right - left;
                 result[i] = temp;
                 
             }
             else
             {
                 while(right < temperatures.Length - 1)
                 {
                     if (temperatures[left] < temperatures[right]) break;
                     right++;
                     
                 }

                 if (temperatures[left] < temperatures[right])
                 {
                     temp = right - left;
                     result[i] = temp;

                 }
                 else
                 {
                     result[i] = 0;
                 }
             }
         }

         return result;
     }
 }