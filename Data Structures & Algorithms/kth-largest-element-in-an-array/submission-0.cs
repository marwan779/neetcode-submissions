 public class Solution
 {
     public int FindKthLargest(int[] nums, int k)
     {
         if(nums.Length == 1) return nums[0];

         PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();

         for (int i = 0; i < nums.Length; i++)
         {
             maxHeap.Enqueue(nums[i], -nums[i]);
         }

         for(int i = 0; i < (k - 1); i++)
         {
             maxHeap.Dequeue();
         }

         return maxHeap.Dequeue();
     }
 }