 public class Solution
 {
     public bool SearchMatrix(int[][] matrix, int target)
     {
     
         for (int i = 0; i < matrix.GetLength(0); i++)
         {
             int[] temp = matrix[i];
             int left = 0;
             int right = temp.Length - 1;

             while (left <= right)
             {
                 int mid = (left + right) / 2;

                 if (temp[mid] == target) return true;
                 else if (temp[mid] < target)
                 {
                     left = mid + 1;
                 }
                 else
                 {
                     right = mid - 1;
                 }
             }
         }
         

         return false;
     }
 }